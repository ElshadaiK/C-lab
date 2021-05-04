using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The sum is {Sum(num1, num2)}");
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
