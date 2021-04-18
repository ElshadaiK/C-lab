using System;

namespace Question94
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, -30, -40 };
            int max = arr[0];
            for(int i = 1; i<arr.Length-1; i++)
            {
                if(max<arr[i])
                {
                    max = arr[i];
                }
            }
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = max;
            }

            foreach(int num in arr)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
