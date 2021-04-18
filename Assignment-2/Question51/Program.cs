using System;

namespace Question51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(11, 21, 31));
            Console.WriteLine(helper(11, 22, 31));
            Console.WriteLine(helper(10, 20, 16));

            static bool helper(int num1, int num2, int num3)
            {
                if (Math.Abs(num1 - num2) >= 20 || Math.Abs(num1 - num3) >= 20 || Math.Abs(num2 - num3) >= 20) {
                    return true;
                } else {
                    return false;
                }
            }
        }
    }
}
