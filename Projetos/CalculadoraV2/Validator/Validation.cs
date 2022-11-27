using CalculatorV2.Interfaces;
using CalculatorV2.Enums;

namespace CalculatorV2.Validator
{
    public class Validator : IValidator
    {
        public static List<string> _validOperations = Enum.GetValues(typeof(OperationsEnum))
                                                                                .Cast<OperationsEnum>()
                                                                                .Select(op => op.ToString())
                                                                                .ToList();
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