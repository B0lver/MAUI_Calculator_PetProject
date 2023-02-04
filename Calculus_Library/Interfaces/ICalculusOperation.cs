using System.Numerics;

namespace Calculus_Library.Interfaces
{
    public interface ICalculusOperation
    {
        dynamic Execute();
        bool CanGetResult();
    }
}