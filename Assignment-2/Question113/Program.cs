using System;

namespace Question113
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new int[] { 1, 5, 6, 9, 10, 17}));
            Console.WriteLine(helper(new int[] { 1, 5, 5, 9, 10, 17}));
            Console.WriteLine(helper(new int[] { 1, 5, 5, 9, 10, 17, 5, 5}));

            static bool helper(int[] arr)
            {   
                for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] == 5 && arr[i + 1] == 5) {
                        return true;
                    }   
                }
                return false;
            }
        }
    }
}
