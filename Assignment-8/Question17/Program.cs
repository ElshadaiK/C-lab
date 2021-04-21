using System;

namespace Question17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
			string str = Console.ReadLine();
			Console.Write("Input a substring to be found in the string: ");
			string toBeSearched = Console.ReadLine();

            int index = str.IndexOf(toBeSearched);
            System.Console.WriteLine($"Found {toBeSearched} at index position {index}");
        }
    }
}
