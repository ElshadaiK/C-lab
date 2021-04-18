using System;
using System.Linq;
using System.Collections.Generic;

namespace Question144
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static List<string> Question144(List<string> nums_str)
        {
            IEnumerable<string> s = nums_str.Select(x => x = x + x + x + x);
            return s.ToList();
        }
    }
}
