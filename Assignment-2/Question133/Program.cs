using System;

namespace Question133
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new[] { 5, 5, 1, 5, 5 }));
            Console.WriteLine(helper(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(helper(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(helper(new[] { 1, 5, 5, 7, 8, 10 }));

            static bool helper(int[] numbers)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i + 1] < numbers[i]) return false;
                }

                return true;
            }
        }
    }
}
