using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input any number: ");
            int num = Convert.ToInt32(Console.ReadLine()); 
            Console.Write($"The digits in the number {num} are: ");
            DisplayIndividialDigits(num);
        }

        static void DisplayIndividialDigits(int n)
        {
            if (n < 10)
            {
                Console.Write("{0} ", n);
                return;
            }
            DisplayIndividialDigits(n / 10);
            Console.Write("{0} ", n % 10);
        }
    }
}
