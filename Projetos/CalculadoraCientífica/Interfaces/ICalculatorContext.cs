using ScientificCalculatorApp.Interfaces;

namespace ScientificCalculatorApp.Interfaces
{
    public interface ICalculatorContext
    {
        IMathOperation Addition { get; }

        IMathOperation Subtraction { get; }

        IMathOperation Multiplication { get; }

        IMathOperation Division { get; }

        IMathOperation Exponentiation { get; }

        IMathOperation Radication { get; }
    }
}