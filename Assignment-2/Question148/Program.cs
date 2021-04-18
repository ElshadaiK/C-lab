using System;
using System.Linq;
using System.Collections.Generic;

namespace Question148
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrWithOuta = replacer(new List<string> (new string[] { "abc", "cdaef", "js" , "php" }));
            
            foreach(var i in arrWithOuta)
            {
                Console.Write(i.ToString()+" ");
            }
        }
        static List<string> replacer(List<string> str)
        {
            return str.Select(x => x.Replace("a", "")).ToList();
        }
    }
}
