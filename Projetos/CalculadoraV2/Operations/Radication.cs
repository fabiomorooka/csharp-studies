using CalculatorV2.Interfaces;

namespace CalculatorV2.Helpers
{
    public class Radication : IMathOperation
    {
        public double DoMathOperation(double num1, double num2)
        {
            if (num2 != 0 && num1 != 1)
            {
                return Math.Pow(num1, 1 / num2);          
            }
            else if (num1 == 1)
            {
                throw new ArithmeticException("Infinty exception");
            }
            else
            {
                throw new DivideByZeroException($"Division of {num1} by zero.");
            }
        }
    }
}