using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3, 0, 8, 1, 2, 5, 7, 9, 6, 4};
            int[] sortedarray = InsertionSort(array);
            Console.WriteLine("Sorted array: {0}", string.Join(", ", sortedarray));
        }
        static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; ++i)
            {
                int currentValue = array[i];
                int pointer = i - 1;

                while (pointer >= 0 && array[pointer] > currentValue)
                {
                    array[pointer + 1] = array[pointer];
                    pointer = pointer - 1;
                }
                array[pointer + 1] = currentValue;
            }
            return array;
        }
    }
}
