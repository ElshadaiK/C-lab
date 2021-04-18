using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (EvenOrOdd(num)) Console.WriteLine($"{num} is Even.");
            else Console.WriteLine($"{num} is Odd.");
        }

        static bool EvenOrOdd(int num)
        {
            if (num % 2 == 0) return true;
            return false;
        }
    }
}
