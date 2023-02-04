using Calculus_Library.Interfaces;
using Calculus_Library.Interfaces.Extensions;
using Calculus_Library.Operations.Base;

namespace Calculus_Library.Operations.Trigonometry
{
    public sealed class Sin : UnaryOperation
    {
        private readonly bool isDegreesUsed;
        public Sin(IValue a, IUnaryExtension extension = null, bool isDegreesUsed = false)
            : base(a, extension)
        {
            this.isDegreesUsed = isDegreesUsed;
        }

        public override dynamic Execute()
        {
            if (isDegreesUsed){
                return Math.Sin((AValue.GetValue() / 180d) * Math.PI);
            }
            return Math.Sin(AValue.GetValue()); ;
        }
    }
}
