using System;

namespace CarLot
{
    public class Validate
    {
        public static bool MatchPattern()
        {
            throw new NotImplementedException();
        }

        public static string InputString(string query, string input = "")
        {
            Console.Write($"Please enter a value for {query}: ");
            input = Console.ReadLine();

            while (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                Console.Clear();
                Console.WriteLine($"That input was not correct for {query}");
                Console.Write($"Please enter a value for {query}: ");
                input = Console.ReadLine();
            }

            return input;
        }

        public static int InputInt(string query, int input = 0)
        {
            Console.Write($"Please enter a value for {query}: ");            

            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.Clear();
                Console.WriteLine($"That input was not correct for {query}");
                Console.Write($"Please enter a value for {query}: ");
            }

            return input;
        }

        public static double InputDouble(string query, double input = 0)
        {
            Console.Write($"Please enter a value for {query}: ");

            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.Clear();
                Console.WriteLine($"That input was not correct for {query}");
                Console.Write($"Please enter a value for {query}: ");
            }

            return input;
        }
    }
}