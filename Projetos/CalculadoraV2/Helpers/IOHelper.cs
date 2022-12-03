using CalculatorV2.Interfaces;
using CalculatorV2.Enums;

namespace CalculatorV2.Helpers
{
    public class IOHelper: IIOHelper
    {
        public string ReadInput(string message)
        {
            Console.Write(message);

            string? input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                input = ReadInput("The input cannot be null or empty. Please enter an valid value: ");
            }

            return input.ToLower();
        }

        public void ShowOperationOptions()
        {
            Console.WriteLine("Choose an operator from the following list:");
            foreach (int option in Enum.GetValues(typeof(OperationsEnum)))
            {
                Console.WriteLine($"\t{option} - {(OperationsEnum)option} ");
            }
        }
        public void ShowCloseOptions()
        {
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine($"\ty - Yes");
            Console.WriteLine($"\tn - No");
        }
    }
}