using Calculus_Library.Interfaces.Extensions;

namespace Calculus_Maui_Controls.Extensions.UnaryExtensions
{
    public class SinExtension : IUnaryExtension
    {
        public string GetPrefix()
        {
            return "Sin(";
        }
        public string GetSuffix()
        {
            return ")";
        }
    }
}
