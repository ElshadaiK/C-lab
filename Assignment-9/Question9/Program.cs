using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(num))
                Console.WriteLine($"{num} is a prime number");
            else
                Console.WriteLine($"{num} is not a prime number");
        }

        public static bool IsPrime(int num)
        {
            for (int i=2; i < num; i++)
            if (num % i == 0) 
                return false;
            return true;
        }
    }
}
