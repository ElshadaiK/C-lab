using System;

namespace Question57
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
                foreach (int element in nums)
                {
                    if (element >= 10 && element <= 20)
                    {
                        if (element == 13 || element == 17)
                        {
                            total += element;
                        }

                    }
                    else
                    {
                        total += element;
                    }
                }
                return total;

            }
        }
    }
}
