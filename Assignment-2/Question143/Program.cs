using System;
using System.Linq;
using System.Collections.Generic;

namespace Question143
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static List<string> Question143(List<string> nums_str)
        {
            IEnumerable<string> s = nums_str.Select(x => "#" + x + "#");
            return s.ToList();
        }
    }
}
