using System;

namespace Question109
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 7, 9, 10, 12 };
            int count = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    count++;
                }
            }
            Console.Write(count);
        }
    }
}
