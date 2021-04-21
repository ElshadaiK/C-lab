using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {3, 0, 8, 1, 2, 5, 7, 9, 6, 4};
            int[] sortedArr = BubbleSort(arr);
            Console.WriteLine("Sorted array: {0}", string.Join(", ", sortedArr));
        }
        static int[] BubbleSort(int[] arr)
        {
            var len = arr.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }

            return arr;
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
