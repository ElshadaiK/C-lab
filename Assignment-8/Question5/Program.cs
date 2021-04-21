using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();

            int count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ') {
                    count++;
                }
            }
            Console.WriteLine($"Total number of words in the string is: {count}");
        }
    }
}
