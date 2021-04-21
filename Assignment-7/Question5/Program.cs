using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3, 0, 8, 1, 2, 5, 7, 9, 6, 4};
            int[] sortedarray = HeapSort(array);
            Console.WriteLine("Sorted array: {0}", string.Join(", ", sortedarray));
        }
        static void Heapify(int[] array, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < length && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                Heapify(array, length, largest);
            }
        }
        static int[] HeapSort(int[] array)
        {
            var length = array.Length;
            for (int i = length / 2 - 1; i >= 0; i--)
            {
                Heapify(array, length, i);
            }
            for (int i = length - 1; i >= 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                Heapify(array, i, 0);
            }
            return array;
        }
    }
}
