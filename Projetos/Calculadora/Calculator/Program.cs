using Calculator.CalculatorSystem;
using InputOutputHelper;
using Calculator.Validator;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console Calculator Project\r");
        Console.WriteLine(string.Concat(Enumerable.Repeat("#", 75)) + "\n");

        do
        {
            string message = "Type a number, and then press Enter: ";
            string errorMessage = "Invalid number. Please type a number, and then press Enter: ";

            bool isInputValid=true;
            string input;
            double inputNumber1;
            do
            {
                if (isInputValid)
                {
                    input = IOHelper.ReadInput(message);
                }
                else
                {
                    input = IOHelper.ReadInput(errorMessage);
                }
                isInputValid = Validator.ValidateInputNumber(input, out inputNumber1);
            } while (!isInputValid);

            double inputNumber2;
            do
            {
                if (isInputValid)
                {
                    input = IOHelper.ReadInput(message);
                }
                else
                {
                    input = IOHelper.ReadInput(errorMessage);
                }
                isInputValid = Validator.ValidateInputNumber(input, out inputNumber2);
            } while (!isInputValid);

            string operation;
            do
            {
                IOHelper.ShowOperationOptions();
                operation = IOHelper.ReadInput("Your option? ");
                isInputValid = Validator.ValidateInputOperation(operation);
            } while (!isInputValid);

            try
            {
                double result = BasicCalculator.DoOperation(inputNumber1, inputNumber2, operation);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathematical error.\n");
                }
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
            }

            Console.WriteLine(string.Concat(Enumerable.Repeat("#", 75)) + "\n");

            string finishInput;
            do {
                IOHelper.ShowCloseOptions();
                finishInput = IOHelper.ReadInput("Do you wish to continue using the app? ");
                isInputValid = Validator.ValidateFinishOption(finishInput);
            } while (!isInputValid);
            
            if (finishInput == "n")
            {
                endApp = true;
                Console.WriteLine("\nThank you for using this calculator!");
            }
        } while (!endApp);
        return;
    }
}