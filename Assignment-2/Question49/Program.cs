using System;

namespace Question49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(1, 2, 3, false));
            Console.WriteLine(helper(1, 2, 3, true));
            Console.WriteLine(helper(10, 2, 30, false));
            Console.WriteLine(helper(10, 10, 30, true));

            static bool helper(int num1, int num2, int num3, bool flag)
            {
                return flag ? num1 <= num2 && num2 <= num3 : num1 < num2 && num2 < num3;
            }
        }
    }
}
