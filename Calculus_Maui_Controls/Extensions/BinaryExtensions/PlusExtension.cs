using Calculus_Library.Interfaces.Extensions;

namespace Calculus_Maui_Controls.Extensions.BinaryExtensions
{
    public class PlusExtension : IBinaryExtension
    {
        public string GetMiddleSymbol()
        {
            return "+";
        }

        public string GetPrefix()
        {
            return "";
        }

        public string GetSuffix()
        {
            return "";
        }
    }
}
