using System;

namespace Question137
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] item = helper(new[] {"a", "b", "bb", "c", "ccc" }, 3);            
            Console.Write("New array: ");         
            foreach(var i in item)
            {
                Console.Write(i.ToString()+" ");
            }     
        }
        static string[] helper(string[] arr_str, int n)
         {
           string[] new_array = new string[n];

            for (int i = 0; i < n; i++)
            {
                new_array[i] = arr_str[i];
            }

            return new_array;
        }
    }
}
