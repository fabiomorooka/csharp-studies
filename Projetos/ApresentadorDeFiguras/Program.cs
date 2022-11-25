using FigureDisplayer.Enums;
using FigureDisplayer.GeometricFigures;
using FigureDisplayer.Helpers;
using FigureDisplayer.Services;
using FigureDisplayer.Validator;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Figure Displayer Console Project\r");
        Console.WriteLine(string.Concat(Enumerable.Repeat("#", 75)) + "\n");

        do
        {
            bool isInputValid;
            string figureType;
            do
            {
                IOHelper.ShowFiguresOptions();
                figureType = IOHelper.ReadInput("Your option? ");
                isInputValid = Validator.ValidateInputFigureType(figureType);
            } while (!isInputValid);

            try
            {
                string figureName = Enum.GetName(typeof(FiguresEnum), Convert.ToInt32(figureType));
                BaseFigure figure = SimpleBuilder.BuildFigure(figureType);
                figure.CalculatePerimeter();
                figure.CalculateArea();
                Console.WriteLine($"The {figureName} built has {Math.Round(figure.Area, 3)} square meter of area and {Math.Round(figure.Perimeter, 3)} meters of perimeter.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Building this figure resulted in an error\n - Details: " + e.Message);
            }

            Console.WriteLine(string.Concat(Enumerable.Repeat("#", 75)) + "\n");

            string finishInput;
            do
            {
                IOHelper.ShowYesOrNoOptions();
                finishInput = IOHelper.ReadInput("Do you wish to continue using the app? ");
                isInputValid = Validator.ValidateYesOrNoOption(finishInput[0]);
            } while (!isInputValid);

            if (finishInput[0] == 'n')
            {
                endApp = true;
                Console.WriteLine("\nThank you for using this displayer!");
            }
        } while (!endApp);
        return;
    }
}