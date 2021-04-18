using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a  number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result {helper(num1)}");
            
            static bool helper(int num1)
            {
                return (Math.Abs(num1 - 100) <= 10) || (Math.Abs(num1 - 200) <= 10) ? true : false;
            }
        }
    }
}
