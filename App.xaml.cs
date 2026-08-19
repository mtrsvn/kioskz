namespace StudentProfileNavigator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(MainPage ?? new NavigationPage(new MainPage()));
	}
}