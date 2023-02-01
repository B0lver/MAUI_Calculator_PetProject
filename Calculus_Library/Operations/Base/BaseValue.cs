using Calculus_Library.Interfaces;

namespace Calculus_Library.Operations.Base
{
    public class BaseValue<T> : IValue<T>
    {
        private readonly T result_value;
        public BaseValue(T result_value)
        {
            this.result_value = result_value;
        }

        public T GetValue()
        {
            return result_value;
        }
    }
}
