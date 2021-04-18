using System;

namespace Question59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Numbers");
            Console.Write("Enter Number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 3:");
            int num3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Result {helper(num1, num2, num3)}");


            static bool helper(int num1, int num2, int num3)
            {
                return (num2 - num1) == (num3 - num2) ? true : false;
            }
        }
    }
}
