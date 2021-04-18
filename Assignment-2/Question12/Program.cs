using System;

namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.StartsWith("C#") || input.StartsWith("c#"));
        }
    }
}
