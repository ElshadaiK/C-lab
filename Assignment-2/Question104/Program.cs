using System;

namespace Question104
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] item = helper(new[] { 10, 20, 30 }, new[] { 40, 50, 60 });       
            Console.Write("New array: ");         
            foreach(var i in item)
            {
                Console.Write(i.ToString()+" ");
            }       
            static int[]helper(int[] nums1, int [] nums2)
            {
                return new int[] { nums1[0], nums1[1], nums1[2], nums2[0], nums2[1], nums2[2] };
            }
        }
    }
}
