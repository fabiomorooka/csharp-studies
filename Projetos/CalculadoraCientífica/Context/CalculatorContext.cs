using ScientificCalculatorApp.Interfaces;

namespace ScientificCalculatorApp.Context
{
    public class CalculatorContext : ICalculatorContext
    {
        public CalculatorContext(IMathOperation addition,
            IMathOperation subtraction,
            IMathOperation multiplication,
            IMathOperation division,
            IMathOperation exponentiation,
            IMathOperation radication)
        {
            Addition = addition;
            Subtraction = subtraction;
            Multiplication = multiplication;
            Division = division;
            Exponentiation = exponentiation;
            Radication = radication;    
        }

        public IMathOperation Addition { get; }

        public IMathOperation Subtraction { get; }

        public IMathOperation Multiplication { get; }

        public IMathOperation Division { get; }

        public IMathOperation Exponentiation { get; }

        public IMathOperation Radication { get; }
    }
}