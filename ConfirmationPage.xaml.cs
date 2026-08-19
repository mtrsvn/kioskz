namespace StudentProfileNavigator;

public partial class ConfirmationPage : ContentPage
{
    private readonly string _name;
    private readonly string _studentNumber;
    private readonly string _email;
    private readonly string _age;
    private readonly string _gender;
    private readonly string _program;

    public ConfirmationPage(
        string name,
        string studentNumber,
        string email,
        string age,
        string gender,
        string program)
    {
        InitializeComponent();

        _name = name;
        _studentNumber = studentNumber;
        _email = email;
        _age = age;
        _gender = gender;
        _program = program;

        lblName.Text = name;
        lblStudentNumber.Text = studentNumber;
        lblEmail.Text = email;
        lblAge.Text = age;
        lblGender.Text = gender;
        lblProgram.Text = program;
    }

    private async void OnConfirmClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(
            new ProfilePage(
                _name,
                _studentNumber,
                _email,
                _age,
                _gender,
                _program));
    }

    private async void OnEditClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
