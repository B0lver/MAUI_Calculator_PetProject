using Calculus_Library.Interfaces;
using Calculus_Library.Interfaces.Extensions;
using Calculus_Library.Operations.Base;

namespace Calculus_Library.Operations.BasicMath
{
    public sealed class Divide : BinaryOperation
    {
        public Divide(IValue a, IValue b, IBinaryExtension extension = null) : base(a, b, extension)
        {
        }

        public override dynamic Execute()
        {
            return  (double)AValue.GetValue() / (double)BValue.GetValue();
        }
    }
}
