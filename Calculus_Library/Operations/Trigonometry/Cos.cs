using Calculus_Library.Interfaces;
using Calculus_Library.Interfaces.Extensions;
using Calculus_Library.Operations.Base;

namespace Calculus_Library.Operations.Trigonometry
{
    public sealed class Cos : UnaryOperation
    {
        private readonly bool isDegreesUsed;
        public Cos(IValue a, IUnaryExtension extension, bool isDegreesUsed = false) : base(a, extension)
        {
            this.isDegreesUsed = isDegreesUsed;
        }

        public override dynamic Execute()
        {
            if (isDegreesUsed) {
                return Math.Cos((AValue.GetValue() / 180d) * Math.PI );
            }
            return Math.Cos(AValue.GetValue());
        }
    }
}
