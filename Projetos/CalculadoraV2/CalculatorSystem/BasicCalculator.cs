using CalculatorV2.Enums;
using CalculatorV2.Interfaces;
using CalculatorV2.Interfaces.Operations;

namespace CalculatorV2.CalculatorSystem
{
    public class BasicCalculator
    {
        private readonly IAddition _addition;
        private readonly ISubtraction _subtraction;
        private readonly IMultiplication _multiplication;
        private readonly IDivision _division;
        private readonly IExponentiation _exponentiation;
        private readonly IRadication _radication;
        public BasicCalculator(ICalculatorContext context)
        {
            _addition = context.Addition;
            _subtraction = context.Subtraction;
            _multiplication = context.Multiplication;
            _division = context.Division;
            _exponentiation = context.Exponentiation;
            _radication = context.Radication;
        }

        public double DoOperation(double num1, double num2, string operation)
        {
            double result = double.NaN;

            switch ((OperationsEnum)(int.Parse(operation)))
            {
                case OperationsEnum.Add:
                    result = _addition.Add(num1, num2);
                    break;
                case OperationsEnum.Subtract:
                    result = _subtraction.Subtract(num1, num2);
                    break;
                case OperationsEnum.Multiply:
                    result = _multiplication.Multiply(num1, num2);  
                    break;
                case OperationsEnum.Divide:
                    if (num2 != 0)
                        result = _division.Divide(num1, num2);
                    break;
                case OperationsEnum.Exponentiation:
                    result = _exponentiation.Exponent(num1, num2);
                    break;
                case OperationsEnum.Radication:
                    if (num2 != 0)
                        result = _radication.Radicate(num1, num2);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}