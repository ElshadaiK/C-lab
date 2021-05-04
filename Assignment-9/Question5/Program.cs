using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,8,9,10};
            System.Console.WriteLine($"The sum is {Sum(arr)}");
        }

        static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0;i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
