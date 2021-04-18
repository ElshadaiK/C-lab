using System;

namespace Question111
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 5, 7, 9, 10, 17};
            Console.WriteLine($"Sum of values except the number 17 is: {helper(arr)}");

            static int helper(int[] arr)
            {   
                int sum = 0;
                if (arr.Length == 0) return 0;
                for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] != 17) sum += arr[i];
                }
                return sum;
            }
        }
    }
}
