using Calculus_Library.Interfaces;
using Calculus_Library.Interfaces.Extensions;
using Calculus_Library.Operations.Base;

namespace Calculus_Library.Operations.BasicMath
{
    public sealed class Multiply : BinaryOperation
    {
        public Multiply(IValue a, IValue b, IBinaryExtension extension = null) : base(a, b, extension)
        {
        }

        public override dynamic Execute()
        {
            return AValue.GetValue() * BValue.GetValue();
        }
    }
}
