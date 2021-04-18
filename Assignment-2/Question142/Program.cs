using System;
using System.Collections;

namespace Question142
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList { 1, 2, 3, 4 };
            ArrayList newArr = new ArrayList();
            foreach (int num in arr)
            {
                newArr.Add(num * 3);
                Console.Write("{0} ", num * 3);
            }
        }
    }
}
