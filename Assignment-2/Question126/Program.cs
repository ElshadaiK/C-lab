using System;

namespace Question126
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new[] { 1, 2, 3, 5, 3, 7 })); 
            Console.WriteLine(helper(new[] { 3, 7, 5, 5, 3, 7 })); 
            Console.WriteLine(helper(new[] { 3, 7, 5, 5, 6, 7, 5 }));

            static bool helper(int[] arr)
            {
                for (int i = 0; i < arr.Length - 3; i++) {
                    if (arr[i] == arr[i + 1] - 1 && arr[i] == arr[i + 2] - 2) {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
