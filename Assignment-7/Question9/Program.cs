using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3, 0, 8, 1, 2, 5, 7, 9, 6, 4};
            int[] sortedarray = QuickSort(array);
            Console.WriteLine("Sorted array: {0}", string.Join(", ", sortedarray));
        }
        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
        static int[] QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);

                QuickSort(array, low, partitionIndex - 1);
                QuickSort(array, partitionIndex + 1, high);
            }
            return array;
        }
        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int lowIndex = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    lowIndex++;

                    int temp = array[lowIndex];
                    array[lowIndex] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = temp1;

            return lowIndex + 1;
        }
    }
}
