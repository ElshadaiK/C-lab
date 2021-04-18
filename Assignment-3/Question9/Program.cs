using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a symbol: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || 
                (symbol == 'o') || (symbol == 'u')) 
                Console.WriteLine("It's a lowercase vowel.");
            else if ((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol."); 
        }
    }
}
