using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0, result = 0;

            Console.Write("Enter a number: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            result = userInput > 51 ? 3 * (userInput - 51) : -(userInput - 51);
            Console.WriteLine($"Result: {result}");
        }
    }
}
