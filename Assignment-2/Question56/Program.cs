using System;

namespace Question56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Numbers");
            Console.Write("Enter Number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 3:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int[] nums = { num1, num2, num3 };

            Console.WriteLine($"Result {helper(nums)}");

            static int helper(int[] nums)
            {
                int total = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 13)
                    {
                        break;
                    }
                    total += nums[i];
                }
                return total;
            }
        }
    }
}
