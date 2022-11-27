using CalculatorV2.Interfaces.Operations;

namespace CalculatorV2.Helpers
{
    public class Exponentiation : IExponentiation
    {
        public double Exponent(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}