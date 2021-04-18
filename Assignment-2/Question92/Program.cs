using System;

namespace Question92
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, -30, -40 };
            int temp = arr[0];
            for(int i = 0; i<3; i++)
            {
                arr[i] = arr[i+1];
            }
            arr[arr.Length-1] = temp;

            foreach(int num in arr)
            {
                Console.Write("{0} ", num);
            }
            Console.Read();
        }
    }
}
