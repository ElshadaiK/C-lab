using System;

namespace Question99
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static int[] Question99(int[] numbers)
        {
            int elements = numbers.Length * 2;
            int[] doubleNumbers = new int[elements];

            doubleNumbers[0] = numbers[0];
            return doubleNumbers;
        }
    }
}
