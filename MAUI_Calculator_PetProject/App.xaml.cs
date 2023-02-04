namespace MAUI_Calculator_PetProject;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Current.UserAppTheme = AppTheme.Dark;
		MainPage = new AppShell();
	}
}
