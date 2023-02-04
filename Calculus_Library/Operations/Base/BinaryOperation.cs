using Calculus_Library.Interfaces;
using Calculus_Library.Interfaces.Extensions;
using Calculus_Library.Operations.DefaultExtensionsClasses;

namespace Calculus_Library.Operations.Base
{
    public abstract class BinaryOperation : IValue, ICalculusOperation
    {
        public IValue AValue { get; }
        public IValue BValue { get; }
        public IBinaryExtension Extension { get; }
        public BinaryOperation(IValue a, IValue b, IBinaryExtension extension = null)
        {
            AValue = a;
            BValue = b;
            Extension = extension ?? new DefaultBinaryExtension();
        }
        public bool CanGetResult()
        {
            return true;
        }
        public abstract dynamic Execute();

        public dynamic GetValue()
        {

            return Execute();
        }
    }
}