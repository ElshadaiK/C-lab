using System;

namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32( Console.ReadLine() );
        
            Console.WriteLine($"The Fibonacci of {num} is {Fibonacci(num)}");
        }

        public static int Fibonacci(int num)
        {
            if (num <= 2)
                return 1;
            else
                return Fibonacci( num - 1 ) + Fibonacci( num - 2 );
        }
    }
}
