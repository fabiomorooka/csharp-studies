using Calculator.Enums;

namespace Calculator.CalculatorSystem
{
    public class BasicCalculator
    {
        public static double DoOperation(double num1, double num2, string operation)
        {
            double result = double.NaN;

            switch ((OperationsEnum)(int.Parse(operation)))
            {
                case OperationsEnum.Add:
                    result = num1 + num2;
                    break;
                case OperationsEnum.Subtract:
                    result = num1 - num2;
                    break;
                case OperationsEnum.Multiply:
                    result = num1 * num2;
                    break;
                case OperationsEnum.Divide:
                    if (num2 != 0)
                        result = num1 / num2;
                    break;
                case OperationsEnum.Exponentiation:
                    result = Math.Pow(num1, num2);
                    break;
                case OperationsEnum.Radication:
                    if (num2 != 0)
                        result = Math.Pow(num1, 1 / num2);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}