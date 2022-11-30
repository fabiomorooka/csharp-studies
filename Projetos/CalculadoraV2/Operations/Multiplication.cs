using CalculatorV2.Interfaces;

namespace CalculatorV2.Helpers
{
    public class Multiplication : IMathOperation
    {
        public double DoMathOperation(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}