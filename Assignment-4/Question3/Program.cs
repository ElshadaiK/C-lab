using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (PositiveOrNegative(num)) Console.WriteLine($"{num} is Positive.");
            else Console.WriteLine($"{num} is Negative.");
        }

        static bool PositiveOrNegative(int num)
        {
            if (num == Math.Abs(num)) return true;
            return false;
        }
    }
}
