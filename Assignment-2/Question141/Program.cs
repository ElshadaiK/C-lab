using System;

namespace Question141
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static int[] Question141(int[] nums, int count)
        {
            int[] evens = new int[count];
            int j = 0;

            for (int i = 0; j < count; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    evens[j] = nums[i];
                    j++;
                }
            }

            return evens;
        }
    }
}
