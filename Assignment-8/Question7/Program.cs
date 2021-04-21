using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();

            int alphabet = 0;
            int digit = 0;
            int special = 0;

            foreach (char chr in input) {
                if (Char.IsDigit(chr)) {
                    digit++;
                }
                else if (Char.IsLetter(chr)) {
                    alphabet++;
                }
                else {
                    special++;
                }
            }
            Console.WriteLine($"Number of Alphabets in the string is: {alphabet}");
            Console.WriteLine($"Number of Digits in the string is: {digit}");
            Console.WriteLine($"Number of Special characters in the string is: {special}");
        }
    }
}
