using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 3;
            for (int power = 0; power <= 32; power++)
                Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0}");
        }
    }
}
