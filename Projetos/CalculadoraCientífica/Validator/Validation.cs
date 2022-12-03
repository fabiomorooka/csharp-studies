using ScientificCalculatorApp.Interfaces;
using ScientificCalculatorApp.Enums;

namespace ScientificCalculatorApp.Validator
{
    public class Validator : IValidator
    {
        public bool ValidateInputNumber(string inputNumber, out double outputNumber)
        {
            return double.TryParse(inputNumber, out outputNumber);
        }

        public bool ValidateInputOperation(string input)
        {
            return Enum.TryParse(input, out OperationsEnum operation) && Enum.IsDefined(typeof(OperationsEnum), operation);
        }

        public bool ValidateFinishOption(string input)
        {
            return input == "y" || input == "n";
        }
    }
}