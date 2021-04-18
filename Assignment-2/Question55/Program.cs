using System;

namespace Question55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(4, 5, 7));
            Console.WriteLine(helper(7, 4, 12));
            Console.WriteLine(helper(10, 10, 12));
            Console.WriteLine(helper(12, 12, 18));

            static int helper(int num1, int num2, int num3) 
            {
                if (num1 == num2) return num3;
                if (num1 == num3) return num2;
                if (num2 == num3) return num1;
                return num1 + num2 + num3;
            }
        }
    }
}
