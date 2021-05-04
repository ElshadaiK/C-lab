using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input base number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the exponent: ");
            int power = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine($"{num} raised to {power} is {Power(num, power)}");
        }

        static double Power(int num, int power)
        {
            return Math.Pow(num, power);
        }
    }
}