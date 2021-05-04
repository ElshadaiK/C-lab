using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input any positive number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The factorial of {num} is {FactorialCalcu(num)}");
        }
        private static double FactorialCalcu(int n1)
        {          
            if (n1 == 0)
            {
                return 1;
            }
            return n1 * FactorialCalcu(n1-1);
        }
    }
}
