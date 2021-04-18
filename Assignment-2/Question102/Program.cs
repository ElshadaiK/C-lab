using System;

namespace Question102
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = test(new[] { 10, 20, -30 }, new[] { 10, 20, 30 });       
            Console.Write("Larger array: ");         
            foreach(var i in arr)
            {
               Console.Write(i.ToString()+" ");
            }

            static int[] test(int[] nums1, int [] nums2)
                {
                    return nums1[0] + nums1[1] + nums1[2] >= nums2[0] + nums2[1] + nums2[2] ? nums1 : nums2;
                }
        }
    }
}
