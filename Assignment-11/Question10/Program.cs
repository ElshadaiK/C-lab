using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of terms for the Fibonacci series: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Fibonacci series of {0} terms is : ", num);
            for (int i = 0; i < num; i++)
            {
                Console.Write("{0} ",FindFibonacci(i));
            }
        }
        static int FindFibonacci(int num)
        {
            int n0 = 0;
            int n1 = 1;
            for (int i = 0; i < num; i++)
            {
                int temp = n0;
                n0 = n1;
                n1 = temp + n1;
            }
            return n0;
        }
    }
}
