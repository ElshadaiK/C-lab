using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input how many numbers to print: ");
            int num= Convert.ToInt32(Console.ReadLine());
            PrintNatural(1, num);
        }

        static int PrintNatural(int stval, int num)
        {
            if (num < 1)
            {
                return stval;
            }
            num--;
            Console.Write("{0} ",stval);
            return PrintNatural(stval + 1, num);
        }
    }
}