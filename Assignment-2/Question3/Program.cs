using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers");
            Console.Write("Enter Number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result {helper(num1, num2)}");

            static bool helper(int num1, int num2)
            {
                return num1 == 20 || num2 == 30 || (num1 + num2) == 30 ? true : false;
            }
        }
    }
}
