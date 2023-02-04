using Calculus_Library.Interfaces.Extensions;

namespace Calculus_Library.Operations.DefaultExtensionsClasses
{
    internal sealed class DefaultBinaryExtension : IBinaryExtension
    {
        public string GetMiddleSymbol()
        {
            return "_";
        }

        public string GetPrefix()
        {
            return string.Empty;
        }

        public string GetSuffix()
        {
            return string.Empty;
        }
    }
}
