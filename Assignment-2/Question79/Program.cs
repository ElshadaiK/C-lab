using System;

namespace Question79
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.Substring(0, input.Length - 2) + input[input.Length - 1] + input[input.Length - 2]);
        }
    }
}
