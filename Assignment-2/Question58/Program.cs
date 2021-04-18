using System;

namespace Question58
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

            static int helper(int num1, int num2)
            {
                return (num1 > 13 || num2 > 13) ? 0 : ((num1 > num2) ? num1 : num2);
            }
        }
    }
}
