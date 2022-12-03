using ScientificCalculatorApp.Interfaces;

namespace ScientificCalculatorApp.Helpers
{
    public class Exponentiation : IMathOperation
    {
        public double DoMathOperation(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}