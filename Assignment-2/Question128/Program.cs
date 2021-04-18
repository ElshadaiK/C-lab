using System;

namespace Question128
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  {1, 2, 3, 5, 7};
            int[] newArr = helper(arr);
            for (int i = 0; i < newArr.Length; i++) {
                Console.Write(newArr[i] + " ");
            }

            static int[] helper(int[] arr) 
            {
                int len = 0;
                for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] == 5) {
                        len = i;
                        break;
                    }
                }
                int[] newArr = new int[len];
                for (int i = 0; i < len; i++) {
                    newArr[i] = arr[i];               
                }
                return newArr;
            }
        }
    }
}
