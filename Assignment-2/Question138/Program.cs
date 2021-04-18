using System;
using System.Collections;

namespace Question138
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList item = helper(new[] {"a", "aaa", "b", "bbb", "c", "ccc" }, 3);            
            Console.Write("New array: ");         
            foreach(var i in item)
            {
                Console.Write(i.ToString()+" ");
            }
        }
        static ArrayList helper(string[] arr_str, int n)
         {
          ArrayList result_arra = new ArrayList();
            for (int i = 0; i < arr_str.Length; i++)
            {
                if (arr_str[i].Length == n)
                {
                    result_arra.Add(arr_str[i]);
                }
            }
            return result_arra;
        }    
    }
}
