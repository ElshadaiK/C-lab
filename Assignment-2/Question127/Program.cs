using System;

namespace Question127
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  {10, 20, -30, -40, 50};
            int[] newArr = helper(arr);
            for (int i = 0; i < newArr.Length; i++) {
                Console.Write(newArr[i] + " ");
            }

            static int[] helper(int[] arr) 
            {
                for (int i = 0; i < 1; i++) {
                    int j, first;
                    first = arr[0];
                    for (j = 0; j < arr.Length - 1; j++) {
                        arr[j] = arr[j + 1];
                    }
                    arr[j] = first;
                }
                return arr;
            }
        }
    }
}
