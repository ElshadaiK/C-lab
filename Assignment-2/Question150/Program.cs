using System;
using System.Linq;
using System.Collections.Generic;

namespace Question150
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 22, 35, 47, 53, 67 };
            List<int> arrWithOuta = new List<int>();
            string check;

            foreach (var num in arr)
            {
                check = Convert.ToString(num);
                if (check[check.Length - 1] != '7')
                {
                    arrWithOuta.Add(int.Parse(check));
                    Console.Write("{0} ", check);
                }
                int[] arrWithNo7 = arrWithOuta.ToArray();
            }
        }
    }
}
