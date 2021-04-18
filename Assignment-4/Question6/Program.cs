using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            if (m > 0) Console.WriteLine("The value of n is 1");
            else if (m == 0) Console.WriteLine("The value of n is 0");
            else Console.WriteLine("The value of n is -1");
        }
    }
}
