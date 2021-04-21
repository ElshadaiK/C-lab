using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {3, 0, 8, 1, 2, 5, 7, 9, 6, 4};
            int[] sortedArr = ShellSort(arr);
            Console.WriteLine("Sorted array: {0}", string.Join(", ", sortedArr));
        }

        static int[] ShellSort(int[] arr)
        {
            var d = arr.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < arr.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (arr[j - d] > arr[j]))
                    {
                        Swap(ref arr[j], ref arr[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
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
