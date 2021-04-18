using System;

namespace Question91
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Question91());
        }

        static int Question91()
        {
            //int[] arr = { 10, 20, 30, 40, 50 };
            int[] arr = { 10, 20, -30, -40, 50 };
            int sum = 0;
            foreach(int num in arr)
            {
                sum+=num;
            }
            return sum;
        }
    }
}
