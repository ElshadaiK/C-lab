using System;
using System.Collections;

namespace Question132
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 3, 5, 4, 6, 9, 11 };
            ArrayList newArr = new ArrayList();

            foreach (var num in arr)
            {
                if (num % 2 == 0)
                {
                    newArr.Insert(0, num);
                }
                else
                {
                    newArr.Add(num);
                }
            }

            int[] new_new_Arr = (int[])newArr.ToArray(typeof(int));

            Console.Write("New array: ");
            Console.WriteLine("[{0}]", string.Join(", ", new_new_Arr));
        }
    }
}
