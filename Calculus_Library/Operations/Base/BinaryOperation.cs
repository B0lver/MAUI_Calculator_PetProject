using Calculus_Library.Interfaces;
using System.Numerics;

namespace Calculus_Library.Operations.Base
{
    public abstract class BinaryOperation<T> : IValue<T>, ICalculusOperation<T> where T : INumber<T>
    {
        protected IValue<T> a_value;
        protected IValue<T> b_value;

        public BinaryOperation(IValue<T> a, IValue<T> b)
        {
            a_value = a;
            b_value = b;
        }
        public bool CanGetResult()
        {
            return true;
        }
        public abstract T Execute();

        public T GetValue()
        {
            return Execute();
        }
    }
}