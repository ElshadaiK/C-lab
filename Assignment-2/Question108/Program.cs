using System;

namespace Question108
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] item = helper(new[] { 1, 5, 7, 9, 11, 13 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            static int[] helper(int[] numbers)
            {
                int[] front_nums;

                if (numbers.Length >= 2)
                {
                    front_nums = new int[] { numbers[0], numbers[1] };
                }
                else if (numbers.Length > 0)
                {
                    front_nums = new int[] { numbers[0] };
                }
                else
                {
                    front_nums = new int[0];
                }

                return front_nums;
            }
        }
    }
}
