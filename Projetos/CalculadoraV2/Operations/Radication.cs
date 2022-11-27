using CalculatorV2.Interfaces.Operations;

namespace CalculatorV2.Helpers
{
    public class Radication : IRadication
    {
        public double Radicate(double num1, double num2)
        {
            return Math.Pow(num1, 1 / num2);
        }
    }
}