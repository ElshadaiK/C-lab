using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();
            int count = 0;
            foreach (char chr in input) {
                count++;
            }
            Console.WriteLine($"Length of the string is: {count}");
        }
    }
}
