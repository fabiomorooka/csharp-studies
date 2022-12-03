using ScientificCalculatorApp.Interfaces;

namespace ScientificCalculatorApp.Helpers
{
    public class Multiplication : IMathOperation
    {
        public double DoMathOperation(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}