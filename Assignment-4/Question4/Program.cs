using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (LeapYear(year)) Console.WriteLine($"{year} is a Leap Year.");
            else Console.WriteLine($"{year} is not a Leap Year.");
        }

        static bool LeapYear(int year)
        {
            if (year % 400 == 0 || year % 4 == 0) return true;
            return false;
        }
    }
}
