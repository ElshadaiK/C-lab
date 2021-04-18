using System;

namespace Question90
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 10, 20, 40, 50 };
            int[] nums2 = { 10, 20, 40, 5 };
            int[] nums3 = { 1, 20, 40, 5 };
            Console.WriteLine($"Result {helper(nums1, nums1)}");
            Console.WriteLine($"Result {helper(nums1, nums2)}");
            Console.WriteLine($"Result {helper(nums1, nums3)}");



            static bool helper(int[] nums1, int[] nums2)
            {
                return nums1[0] == nums2[0] || nums1[nums1.Length - 1] == nums2[nums2.Length - 1] ? true : false;
            }
        }
    }
}
