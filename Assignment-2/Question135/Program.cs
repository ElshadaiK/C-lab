using System;

namespace Question135
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new[] { 1, 2, 3, 4, 6, 8 }));
            Console.WriteLine(helper(new[] { 15, 2, 3, 4, 15, 11 }));

            static int helper(int[] numbers)
            {
                var firstHalf = Average(numbers, 0, numbers.Length / 2);
                var secondHalf = Average(numbers, numbers.Length / 2, numbers.Length);
                return firstHalf > secondHalf ? firstHalf : secondHalf;
            }

            static int Average(int[] num, int start, int end)
            {
                var sum = 0;
                for (var i = start; i < end; i++)
                    sum += num[i];
                return sum / (num.Length / 2);
            }
        }
    }
}
