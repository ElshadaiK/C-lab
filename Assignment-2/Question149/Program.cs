using System;
using System.Linq;
using System.Collections.Generic;

namespace Question149
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, -2, 1, 2, 3, 5 , 4, 7, 8 };
            List<int> arrWithOuta = new List<int>();

            foreach (var num in arr)
            {
                if (num < 4)
                {
                    arrWithOuta.Add(num);
                    Console.Write("{0} ", num);
                }
                int[] arrWithNo7 = arrWithOuta.ToArray();
            }
        }
    }
}
