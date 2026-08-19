namespace StudentProfileNavigator;

public partial class ProfilePage : ContentPage
{
    public ProfilePage(
        string name,
        string studentNumber,
        string email,
        string age,
        string gender,
        string program)
    {
        InitializeComponent();

        lblName.Text = name;
        lblStudentNumber.Text = studentNumber;
        lblEmail.Text = email;
        lblAge.Text = age;
        lblGender.Text = gender;
        lblProgram.Text = program;
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
