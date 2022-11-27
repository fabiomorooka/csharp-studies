using CalculatorV2.Interfaces.Operations;

namespace CalculatorV2.Helpers
{
    public class Division : IDivision
    {
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}