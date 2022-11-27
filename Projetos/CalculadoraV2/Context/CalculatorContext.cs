using CalculatorV2.Interfaces.Operations;
using CalculatorV2.Interfaces;

namespace CalculatorV2.Context
{
    public class CalculatorContext : ICalculatorContext
    {
        public CalculatorContext(IAddition addition, 
            ISubtraction subtraction, 
            IMultiplication multiplication, 
            IDivision division)
        {
            Addition = addition;
            Subtraction = subtraction;
            Multiplication = multiplication;
            Division = division;
        }

        public IAddition Addition { get; }

        public ISubtraction Subtraction { get; }

        public IMultiplication Multiplication { get; }

        public IDivision Division { get; }
    }
}