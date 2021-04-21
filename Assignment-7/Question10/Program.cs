using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3, 0, 8, 1, 2, 5, 7, 9, 6, 4};
            int[] sortedarray = RadixSort(array);
            Console.WriteLine("Sorted array: {0}", string.Join(", ", sortedarray));
        }
        static int[] RadixSort(int[] array)
        {
            return RadixSort(array, array.Length);
        }
        static int[] RadixSort(int[] arr, int n)
        {
            int m = GetMax(arr, n);
            for (int exp = 1; m / exp > 0; exp *= 10)
            {
                CountSort(arr, n, exp);
            }
      
            return arr;
        }
        static void CountSort(int[] arr, int n, int exp)
        {
            int[] sortedArray = new int[n];
            int i;
            int[] count = new int[10];
    
            for (i = 0; i < 10; i++)
                count[i] = 0;

            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (i = n - 1; i >= 0; i--) {
                sortedArray[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            for (i = 0; i < n; i++)
                arr[i] = sortedArray[i];
        }
        public static int GetMax(int[] arr, int n)
        {
            int max = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
    }
}
