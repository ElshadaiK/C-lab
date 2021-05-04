using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input any number: ");
            int num = Convert.ToInt32(Console.ReadLine());           
            Console.Write("The number {0} contains {1} digits.",num,NoOfDigits(num, 0));
        }

        static int NoOfDigits(int n1, int nodigits)
        {
            if (n1 == 0)
                return nodigits;

            return NoOfDigits(n1 / 10, ++nodigits);
        }
    }
}
