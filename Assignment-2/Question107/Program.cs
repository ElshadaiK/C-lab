using System;
using System.Linq;

namespace Question107
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            if (arr.Length > 0 && arr.Length % 2 != 0)
            {
                Console.WriteLine(arr.Max());
            }
        }
    }
}
