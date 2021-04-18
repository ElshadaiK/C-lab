using System;

namespace Question130
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  {1, 2, 0, 3, 5, 7, 0, 9, 11};
            int[] newArr = helper(arr);
            for (int i = 0; i < newArr.Length; i++) {
                Console.Write(newArr[i] + " ");
            }

            static int[] helper(int[] arr) {
                int zero = 0;
                for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] == 0) {
                        arr[i] = arr[zero];
                        arr[zero++] = 0;
                    }
                }
                return arr;
            }
        }
    }
}
