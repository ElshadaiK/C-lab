using System;

namespace Question95
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 20, -30, -40, 30 };
            int[] arr2 = { 10, 20, 30, 40, 30 };

            int[] arr = {arr1[arr1.Length/2], arr2[arr2.Length/2]};
            
            foreach(int num in arr)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
