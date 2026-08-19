namespace StudentProfileNavigator;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnNameTextChanged(object? sender, TextChangedEventArgs e)
    {
        int count = e.NewTextValue?.Length ?? 0;
        lblCharacterCount.Text = $"Characters: {count}";
    }

    private async void OnContinueClicked(object? sender, EventArgs e)
    {
        string name = txtName.Text?.Trim() ?? "";
        string studentNumber = txtStudentNumber.Text?.Trim() ?? "";
        string email = txtEmail.Text?.Trim() ?? "";
        string ageText = txtAge.Text?.Trim() ?? "";

        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(studentNumber) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(ageText) ||
            pickerGender.SelectedIndex == -1 ||
            pickerProgram.SelectedIndex == -1)
        {
            await DisplayAlert(
                "Incomplete Information",
                "Please complete all fields before continuing.",
                "OK");

            return;
        }

        if (!email.Contains("@") || !email.Contains(".") || email.IndexOf("@") > email.LastIndexOf("."))
        {
            await DisplayAlert(
                "Invalid Email",
                "Please enter a valid email address (e.g., student@example.com).",
                "OK");

            return;
        }

        if (!int.TryParse(ageText, out int age) || age <= 0)
        {
            await DisplayAlert(
                "Invalid Age",
                "Please enter a valid positive number for age.",
                "OK");

            return;
        }

        string gender = pickerGender.SelectedItem?.ToString() ?? "";
        string program = pickerProgram.SelectedItem?.ToString() ?? "";

        await Navigation.PushAsync(
            new ConfirmationPage(
                name,
                studentNumber,
                email,
                ageText,
                gender,
                program));
    }

    private void OnResetClicked(object? sender, EventArgs e)
    {
        txtName.Text = string.Empty;
        txtStudentNumber.Text = string.Empty;
        txtEmail.Text = string.Empty;
        txtAge.Text = string.Empty;
        pickerGender.SelectedIndex = -1;
        pickerProgram.SelectedIndex = -1;
        lblCharacterCount.Text = "Characters: 0";
    }
}
