using System;

namespace Question18
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter a character: ");
            char chr = Convert.ToChar(Console.ReadLine());

            if (Char.IsLetter(chr))
            {
                if (Char.IsUpper(chr)) {
                    System.Console.WriteLine("The character is uppercase.");
                }
                else {
                    System.Console.WriteLine("The character is lowercase.");
                }
            }
            else {
                System.Console.WriteLine("Input is NOT an alphabet.");
            }
        }
    }
}
