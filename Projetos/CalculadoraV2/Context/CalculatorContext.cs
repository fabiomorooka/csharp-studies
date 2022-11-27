using CalculatorV2.Interfaces.Operations;
using CalculatorV2.Interfaces;

namespace CalculatorV2.Context
{
    public class CalculatorContext : ICalculatorContext
    {
        public CalculatorContext(IAddition addition, 
            ISubtraction subtraction, 
            IMultiplication multiplication, 
            IDivision division,
            IExponentiation exponentiation,
            IRadication radication)
        {
            Addition = addition;
            Subtraction = subtraction;
            Multiplication = multiplication;
            Division = division;
            Exponentiation = exponentiation;
            Radication = radication;    
        }

        public IAddition Addition { get; }

        public ISubtraction Subtraction { get; }

        public IMultiplication Multiplication { get; }

        public IDivision Division { get; }

        public IExponentiation Exponentiation { get; }

        public IRadication Radication { get; }
    }
}