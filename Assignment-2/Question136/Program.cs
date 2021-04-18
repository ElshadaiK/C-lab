using System;

namespace Question136
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static int Question136(string[] arr_str, int len)
         {
           int ctr = 0;

            for (int i = 0; i < arr_str.Length; i++)
            {
                if (arr_str[i].Length == len) ctr++;
            }
            return ctr;
        }
    }
}
