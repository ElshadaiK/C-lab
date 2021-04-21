using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();
            
            foreach (char chr in input)
            {
                Console.Write(chr + " ");
            }
        }
    }
}
