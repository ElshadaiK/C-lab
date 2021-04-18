using System;

namespace Question115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new[] { 1, 5, 6, 9, 10, 17 })); 
            Console.WriteLine(helper(new[] { 1, 5, 5, 5, 10, 17 })); 
            Console.WriteLine(helper(new[] { 1, 1, 5, 5, 5, 5}));

            static bool helper(int[] arr)
            {   
                int sum = 0;
                for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] == 5) sum += arr[i];
                }
                if (sum == 15) return true;
                else return false;
            }
        }
    }
}
