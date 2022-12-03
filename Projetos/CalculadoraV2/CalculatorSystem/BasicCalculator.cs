using CalculatorV2.Enums;
using CalculatorV2.Interfaces;

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
                    result = _context.Addition.DoMathOperation(num1, num2);
                    break;
                case OperationsEnum.Subtract:
                    result = _context.Subtraction.DoMathOperation(num1, num2);
                    break;
                case OperationsEnum.Multiply:
                    result = _context.Multiplication.DoMathOperation(num1, num2);  
                    break;
                case OperationsEnum.Divide:
                        result = _context.Division.DoMathOperation(num1, num2);
                    break;
                case OperationsEnum.Exponentiation:
                    result = _context.Exponentiation.DoMathOperation(num1, num2);
                    break;
                case OperationsEnum.Radication:
                        result = _context.Radication.DoMathOperation(num1, num2);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}