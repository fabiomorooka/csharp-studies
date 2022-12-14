using CalculatorV2.Interfaces;

namespace CalculatorV2.Helpers
{
    public class Exponentiation : IMathOperation
    {
        public double DoMathOperation(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}