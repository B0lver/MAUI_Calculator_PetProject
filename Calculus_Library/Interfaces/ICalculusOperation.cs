using System.Numerics;

namespace Calculus_Library.Interfaces
{
    public interface ICalculusOperation<T> where T : INumber<T>
    {
        T Execute();
        bool CanGetResult();
    }
}