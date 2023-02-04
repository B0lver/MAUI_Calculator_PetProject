using Calculus_Library.Interfaces.Extensions;

namespace Calculus_Maui_Controls.Extensions.UnaryExtensions
{
    public sealed class CosExtension : IUnaryExtension
    {

        public string GetPrefix()
        {
            return "Cos(";
        }

        public string GetSuffix()
        {
            return ")";
        }
    }
}
