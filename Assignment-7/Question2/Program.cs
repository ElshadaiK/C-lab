using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {3, 0, 8, 1, 2, 5, 7, 9, 6, 4};
            int[] sortedArr = BogoSort(arr);
            Console.WriteLine("Sorted array: {0}", string.Join(", ", sortedArr));
        }
        static int[] BogoSort(int[] array)
        {
            while (!IsSorted(array))
            {
                array = Shuffle(array);
            }

            return array;
        }
        static bool IsSorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    return false;
            }

            return true;
        }
        static int[] Shuffle(int[] array)
        {
            Random random = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int i = random.Next(n + 1);
                int temp = array[i];
                array[i] = array[n];
                array[n] = temp;
            }

            return array;
        }
    }
}
