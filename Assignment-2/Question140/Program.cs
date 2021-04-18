using System;

namespace Question140
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] item = helper(new[] {1,2,3,5,7,9,10},3);          
            Console.Write("New array: ");         
            foreach(var i in item)
            {
                Console.Write(i.ToString()+" ");
            }
        }
        static int[] helper(int[] nums, int count)
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
