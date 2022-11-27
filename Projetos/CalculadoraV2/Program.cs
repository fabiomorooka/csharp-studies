using CalculatorV2.CalculatorSystem;
using CalculatorV2.Helpers;
using CalculatorV2.Validator;
using CalculatorV2.Interfaces;
using CalculatorV2.Context;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        ICalculatorContext calculatorContext = new CalculatorContext(new Addition(), new Subtraction(), 
                                                                                                        new Multiplication(), new Division(),
                                                                                                            new Exponentiation(), new Radication());
        IIOHelper _iOHelper = new IOHelper();
        IValidator _validator = new Validator();
        
        BasicCalculator calculator = new BasicCalculator(calculatorContext);
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
                    input = _iOHelper.ReadInput(message);
                }
                else
                {
                    input = _iOHelper.ReadInput(errorMessage);
                }
                isInputValid = _validator.ValidateInputNumber(input, out inputNumber1);
            } while (!isInputValid);

            double inputNumber2;
            do
            {
                if (isInputValid)
                {
                    input = _iOHelper.ReadInput(message);
                }
                else
                {
                    input = _iOHelper.ReadInput(errorMessage);
                }
                isInputValid = _validator.ValidateInputNumber(input, out inputNumber2);
            } while (!isInputValid);

            string operation;
            do
            {
                _iOHelper.ShowOperationOptions();
                operation = _iOHelper.ReadInput("Your option? ");
                isInputValid = _validator.ValidateInputOperation(operation);
            } while (!isInputValid);

            try
            {
                double result = calculator.DoOperation(inputNumber1, inputNumber2, operation);
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
                _iOHelper.ShowCloseOptions();
                finishInput = _iOHelper.ReadInput("Do you wish to continue using the app? ");
                isInputValid = _validator.ValidateFinishOption(finishInput);
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