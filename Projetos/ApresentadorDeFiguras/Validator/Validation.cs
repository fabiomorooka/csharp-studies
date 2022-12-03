using FigureDisplayerApp.Enums;

namespace FigureDisplayerApp.Validator
{
    public class Validator
    {
        public static List<string> _validOperations = Enum.GetValues(typeof(FiguresEnum))
                                                                                .Cast<FiguresEnum>()
                                                                                .Select(op => op.ToString())
                                                                                .ToList();
        public static bool ValidateInputNumber(string inputNumber, out double outputNumber)
        {
            return double.TryParse(inputNumber, out outputNumber);
        }

        public static bool ValidateInputFigureType(string input)
        {
            return Enum.TryParse(input, out FiguresEnum figureType) && Enum.IsDefined(typeof(FiguresEnum), figureType);
        }

        public static bool ValidateYesOrNoOption(char input)
        {
            return (input == 'y') || (input == 'n');
        }
    }
}