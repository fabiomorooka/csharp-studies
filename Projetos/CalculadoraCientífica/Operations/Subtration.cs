using ScientificCalculatorApp.Interfaces;

namespace ScientificCalculatorApp.Helpers
{
    public class Subtraction : IMathOperation
    {
        public double DoMathOperation(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}