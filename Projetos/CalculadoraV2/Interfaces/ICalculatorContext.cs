using CalculatorV2.Interfaces.Operations;

namespace CalculatorV2.Interfaces
{
    public interface ICalculatorContext
    {
        IAddition Addition { get; }

        ISubtraction Subtraction{ get; }

        IMultiplication Multiplication { get; }

        IDivision Division{ get; }
    }
}