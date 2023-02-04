using Calculus_Library.Interfaces;

namespace Calculus_Library.Operations.Base
{
    public class BaseValue : IValue
    {
        public dynamic ResultValue { get; }
        public BaseValue(dynamic result_value)
        {
            this.ResultValue = result_value;
        }

        public dynamic GetValue()
        {
            return ResultValue;
        }
    }
}
