using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3, 0, 8, 1, 2, 5, 7, 9, 6, 4};
            int[] sortedarray = SelectionSort(array);
            Console.WriteLine("Sorted array: {0}", string.Join(", ", sortedarray));
        }
        static int[] SelectionSort(int []array)
        {
            int n = array.Length;
    
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }    
                }
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            return array;
        }
    }
}
