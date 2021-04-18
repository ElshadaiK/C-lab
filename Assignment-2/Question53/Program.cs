using System;

namespace Question53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(11, 21));
            Console.WriteLine(helper(11, 20));
            Console.WriteLine(helper(10, 10));

            static bool helper(int num1, int num2)
            {
                if ((num1 / 10 == num2 / 10) || (num1 % 10 == num2 % 10)) return true;
                return false;
            }
        }
    }
}
