using ScientificCalculatorApp.System;
using ScientificCalculatorApp.Helpers;
using ScientificCalculatorApp.Validator;
using ScientificCalculatorApp.Interfaces;
using ScientificCalculatorApp.Context;

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

        ScientificCalculator calculator = new ScientificCalculator(calculatorContext);
        Console.WriteLine("Welcome to the Scientific Calculator App project!\r");
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
                Console.WriteLine($"Your result: {result}\n");
            }
            catch (Exception)
            {
                throw;
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