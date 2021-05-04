using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dividends = { Int32.MaxValue, 23547, 0, -12547, Int32.MinValue };
            int[] divisors = { 4000, -4000 };

            foreach (int divisor in divisors)
            {
                foreach (int dividend in dividends)
                {
                    int remainder;
                    int quotient = Math.DivRem(dividend, divisor, out remainder);
                    Console.WriteLine(@"{0:N0} \ {1:N0} = {2:N0}, remainder {3:N0}",
                                    dividend, divisor, quotient, remainder);
                }
            }
        }
    }
}
