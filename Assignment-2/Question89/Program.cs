using System;

namespace Question89
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 10, 20, 40, 50 };
            int[] nums2 = { 5, 20, 40, 10 };
            int[] nums3 = { 10, 20, 40, 10 };
            int[] nums4 = { 12, 24, 35, 55 };


            Console.WriteLine($"Result {helper(nums1)}");
            Console.WriteLine($"Result {helper(nums2)}");
            Console.WriteLine($"Result {helper(nums3)}");
            Console.WriteLine($"Result {helper(nums4)}");


            static bool helper(int[] nums)
            {
                if (nums.Length > 1)
                {
                    return nums[0] == nums[nums.Length - 1] ? true : false;
                }
                return false;
            }
        }
    }
}
