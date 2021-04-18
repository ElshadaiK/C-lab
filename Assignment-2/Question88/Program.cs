using System;

namespace Question88
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
                return nums[0] == 10 || nums[nums.Length - 1] == 10 ? true : false;

            }
        }
    }
}
