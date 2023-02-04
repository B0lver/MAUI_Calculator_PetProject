using Calculus_Library.Interfaces;
using Calculus_Library.Interfaces.Extensions;
using Calculus_Library.Operations.DefaultExtensionsClasses;

namespace Calculus_Library.Operations.Base
{
    public abstract class UnaryOperation : IValue, ICalculusOperation
    {
        public IValue AValue { get; }
        public IUnaryExtension UnaryExtension { get; }
        public UnaryOperation(IValue a, IUnaryExtension extension = null)
        {
            this.AValue = a;
            this.UnaryExtension = extension ?? new DefaultUnaryExtension();
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