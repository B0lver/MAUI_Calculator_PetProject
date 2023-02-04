using Calculus_Library.Interfaces;
using Calculus_Library.Operations.Base;
using Calculus_Library.Operations.BasicMath;
using Calculus_Library.Operations.Trigonometry;
using Calculus_Maui_Controls.Extensions.BinaryExtensions;
using Calculus_Maui_Controls.Extensions.UnaryExtensions;
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

        [ObservableProperty]
        BaseValue result;

        [ObservableProperty]
        IValue finalOperation;
        public string FullName => $"{FirstName} {LastName}";

        [RelayCommand]
        private void Submit()
        {
            Application.Current.MainPage.DisplayAlert("Полное имя", FullName, "Ок");
        }

        public string TestString { get; set; }
        public MainPageViewModel()
        {
            FinalOperation = FormCalculation();
            Result = new BaseValue(FinalOperation.GetValue());
        }

        private IValue FormCalculation()
        {
            var a = new BaseValue(1);
            var b = new BaseValue(2);
            var c = new Plus(a, b, new PlusExtension());
            var d = new Sin(c, new SinExtension(), true);
            var e = new Cos(c, new CosExtension(), true);
            return new Plus(d, e, new PlusExtension());
        }
    }
}
