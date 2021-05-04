using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            double fact = Factorial(num);
            Console.WriteLine($"The factorial of {num} is {fact}");
        }

        static double Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
    }
}
