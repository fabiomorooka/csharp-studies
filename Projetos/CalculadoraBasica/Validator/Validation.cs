using BasicCalculatorApp.Enums;

namespace BasicCalculatorApp.Validator
{
    public class Validator
    {
        public static bool ValidateInputNumber(string inputNumber, out double outputNumber)
        {
            return double.TryParse(inputNumber, out outputNumber);
        }

        public static bool ValidateInputOperation(string input)
        {
            return Enum.TryParse(input, out OperationsEnum operation) && Enum.IsDefined(typeof(OperationsEnum), operation);
        }

        public static bool ValidateFinishOption(string input)
        {
            return input == "y" || input == "n";
        }
    }
}