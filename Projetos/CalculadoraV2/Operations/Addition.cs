using CalculatorV2.Interfaces.Operations;

namespace CalculatorV2.Helpers
{
    public class Addition: IAddition
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}