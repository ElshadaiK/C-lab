using System;

namespace Question129
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  {1, 2, 3, 5, 7, 9, 11};
            int[] newArr = helper(arr);
            for (int i = 0; i < newArr.Length; i++) {
                Console.Write(newArr[i] + " ");
            }

            static int[] helper(int[] arr) {
                int len = 0;
                for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] == 5) {
                        len = i;
                        break;
                    }
                }
                int[] newArr = new int[arr.Length - 1 - len];
                for (int i = 0; i < arr.Length - 1 - len; i++) {
                    newArr[i] = arr[i + 4];               
                }
                return newArr;
            }
        }
    }
}
