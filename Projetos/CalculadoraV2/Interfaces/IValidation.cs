namespace CalculatorV2.Interfaces
{
    public interface IValidator
    {
        bool ValidateInputNumber(string inputNumber, out double outputNumber);

        bool ValidateInputOperation(string input);

        bool ValidateFinishOption(string input);
    }
}