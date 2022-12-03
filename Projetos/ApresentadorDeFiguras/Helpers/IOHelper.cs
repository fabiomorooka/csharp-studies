using FigureDisplayer.Enums;

namespace FigureDisplayer.Helpers
{
    public class IOHelper
    {
        public static string ReadInput(string message)
        {
            Console.Write(message);

            string? input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                input = ReadInput("The input cannot be null or empty. Please enter an valid value: ");
            }

            return input.ToLower();
        }

        public static void ShowFiguresOptions()
        {
            Console.WriteLine("Choose a figure from the following list:");
            foreach (int option in Enum.GetValues(typeof(FiguresEnum)))
            {
                Console.WriteLine($"\t{option} - {(FiguresEnum)option} ");
            }
        }
        public static void ShowYesOrNoOptions()
        {
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine($"\ty - Yes");
            Console.WriteLine($"\tn - No");
        }
    }
}