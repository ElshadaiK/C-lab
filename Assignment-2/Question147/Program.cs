using System;
using System.Linq;
using System.Collections.Generic;

namespace Question147
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrToUpper = upper(new List<string> (new string[] { "Abc", "cdef", "js" , "php" }));
            
            foreach(var i in arrToUpper)
            {
                Console.Write(i.ToString()+" ");
            }
        }
        static List<string> upper(List<string> str)
        {
            return str.Select(x => x.ToUpper()).ToList();
        }
    }
}
