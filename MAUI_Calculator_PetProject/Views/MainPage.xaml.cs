using MAUI_Calculator_PetProject.ViewModels;

namespace MAUI_Calculator_PetProject;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

