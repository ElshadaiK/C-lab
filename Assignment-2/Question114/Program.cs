using System;

namespace Question114
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new[] { 1, 5, 6, 9, 10, 17 })); 
            Console.WriteLine(helper(new[] { 1, 4, 7, 9, 10, 17 })); 
            Console.WriteLine(helper(new[] { 1, 1, 2, 9, 10, 17}));

            static bool helper(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] == 5 || arr[i] == 7) return true;
                }
                return false;
            }
        }
    }
}
