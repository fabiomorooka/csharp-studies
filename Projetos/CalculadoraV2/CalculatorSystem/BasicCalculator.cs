using CalculatorV2.Enums;
using CalculatorV2.Interfaces;
using CalculatorV2.Interfaces.Operations;

namespace CalculatorV2.CalculatorSystem
{
    public class BasicCalculator
    {
        private readonly ICalculatorContext _context;
        public BasicCalculator(ICalculatorContext context)
        {
            _context = context;
        }

        public double DoOperation(double num1, double num2, string operation)
        {
            double result = double.NaN;

            switch ((OperationsEnum)(int.Parse(operation)))
            {
                case OperationsEnum.Add:
                    result = _context.Addition.Add(num1, num2);
                    break;
                case OperationsEnum.Subtract:
                    result = _context.Subtraction.Subtract(num1, num2);
                    break;
                case OperationsEnum.Multiply:
                    result = _context.Multiplication.Multiply(num1, num2);  
                    break;
                case OperationsEnum.Divide:
                    if (num2 != 0)
                        result = _context.Division.Divide(num1, num2);
                    break;
                case OperationsEnum.Exponentiation:
                    result = _context.Exponentiation.Exponent(num1, num2);
                    break;
                case OperationsEnum.Radication:
                    if (num2 != 0)
                        result = _context.Radication.Radicate(num1, num2);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}