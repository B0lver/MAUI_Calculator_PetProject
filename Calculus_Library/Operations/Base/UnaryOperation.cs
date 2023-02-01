using Calculus_Library.Interfaces;
using System.Numerics;

namespace Calculus_Library.Operations.Base
{
    public abstract class UnaryOperation<T> : IValue<T>, ICalculusOperation<T> where T : INumber<T>
    {
        protected IValue<T> a_value;
        protected T result_value;
        public bool CanGetResult()
        {
            return true;
        }
        public abstract T Execute();

        public T GetValue()
        {
            return result_value;
        }
    }
}