using System;

namespace Question54
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(4, 5));
            Console.WriteLine(helper(7, 4));
            Console.WriteLine(helper(10, 10));

            static int helper(int num1, int num2) {
                int sum = num1 + num2;
                if (sum.ToString().Length > num1.ToString().Length) {
                    return num1;
                } else {
                    return sum;
                }
            }
        }
    }
}
