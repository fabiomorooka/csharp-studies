using Calculator.Enums;

namespace Calculator.Validator
{
    public class Validator
    {
        public static List<string> _validOperations = Enum.GetValues(typeof(OperationsEnum))
                                                                                .Cast<OperationsEnum>()
                                                                                .Select(op => op.ToString())
                                                                                .ToList();
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