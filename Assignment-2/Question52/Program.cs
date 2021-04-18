using System;

namespace Question52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(11, 21));
            Console.WriteLine(helper(11, 20));
            Console.WriteLine(helper(10, 10));

            static int helper(int num1, int num2)
            {
                if (num1 == num2) return 0;
                else if (num1 % 7 == num2 % 7) return Math.Min(num1, num2);
                else return Math.Max(num1, num2);
            }
        }
    }
}
