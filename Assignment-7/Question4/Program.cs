using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3, 0, 8, 1, 2, 5, 7, 9, 6, 4};
            int[] sortedarray = CountSort(array);
            Console.WriteLine("Sorted array: {0}", string.Join(", ", sortedarray));
        }
        static int[] CountSort(int[] array)
        {
            int n = array.Length;
            int[] sortedarray = new int[n];
            int[] count = new int[256];
    
            for (int i = 0; i < 256; ++i)
                count[i] = 0;
    
            for (int i = 0; i < n; ++i)
                ++count[array[i]];

            for (int i = 1; i <= 255; ++i)
                count[i] += count[i - 1];
    
            for (int i = n - 1; i >= 0; i--) {
                sortedarray[count[array[i]] - 1] = array[i];
                --count[array[i]];
            }
            
            return sortedarray;
        }
    }
}
