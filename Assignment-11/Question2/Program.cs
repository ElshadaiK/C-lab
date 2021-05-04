using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input how many numbers to print: ");
            int num= Convert.ToInt32(Console.ReadLine());
            PrintNatural(num, 1);
        }
        static int PrintNatural(int num,int stval)
        {
            if (num < 1)
            {
                return stval;
            }

            Console.Write("{0} ",num);
                num--;
            return PrintNatural(num,stval);
        }
    }
}
