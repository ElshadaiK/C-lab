using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();

            int strLen = input.Length - 1;
            while (strLen >= 0)
            {
                Console.Write(input[strLen] + " ");
                strLen--;
            }
        }
    }
}
