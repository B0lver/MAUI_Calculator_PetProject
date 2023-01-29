using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MAUI_Calculator_PetProject.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        string firstName;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        string lastName;

        public string FullName => $"{FirstName} {LastName}";

        [RelayCommand]
        private void Submit()
        {
            Application.Current.MainPage.DisplayAlert("Полное имя", FullName, "Ок");
        }
    }
}
