using System;

namespace Question110
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Difference between the largest and smallest values: ");
            Console.WriteLine(helper(new[] { 1, 5, 7, 9, 10, 12 }));

            static int helper(int[] nums)
            {
                int small_num = 0, biggest_num = 0;

                if (nums.Length > 0) small_num = biggest_num = nums[0];

                for (int i = 1; i < nums.Length; i++)
                {
                    small_num = Math.Min(small_num, nums[i]);
                    biggest_num = Math.Max(biggest_num, nums[i]);
                }

                return biggest_num - small_num;
            }
        }
    }
}
