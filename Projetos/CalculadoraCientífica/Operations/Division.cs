using ScientificCalculatorApp.Interfaces;

namespace ScientificCalculatorApp.Helpers
{
    public class Division : IMathOperation
    {
        public double DoMathOperation(double num1, double num2)
        {
            if (num2 !=0)
            {
                return num1 / num2;
            }
            else
            {
                throw new DivideByZeroException($"Division of {num1} by zero.");
            }
        }
    }
}