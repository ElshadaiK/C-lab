using System;

namespace Question106
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 7, 9, 11, 13, 67, 89, 4 };
            int[] newArr = new int[3];
            if (arr.Length > 2)
            {
                int half = (int)arr.Length / 2;
                newArr[0] = arr[half - 1];
                newArr[1] = arr[half];
                newArr[2] = arr[half + 1];
            }

            Console.Write("Original array: ");
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.Write("new array: ");
            Console.WriteLine("[{0}]", string.Join(", ", newArr));
        }
    }
}
