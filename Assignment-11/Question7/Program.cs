using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input any positive number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int prime = IsPrime(num ,num / 2);

            if(prime == 1)
                Console.WriteLine("{0} is a prime number.",num);
            else
                Console.WriteLine("{0} is not a prime number.",num);
        }
        static int IsPrime(int num,int i)
        {
            if(i == 1)
            {
                return 1;
            }
            else
            {
            if(num % i == 0)
                return 0;
            else
                return IsPrime(num, i-1);
            }
        }
    }
}
