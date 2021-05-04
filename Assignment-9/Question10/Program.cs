using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the digit: ");
            int num = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine($"The sum of the digits is {SumOfDigits(num)}");
        }

        static int SumOfDigits(int num)
        {
            int sum = 0, rem;
            while (num > 0)
            {
                rem  = num % 10;
                sum += rem;
                num /= 10;
            }
            return sum;
        }
    }
}
