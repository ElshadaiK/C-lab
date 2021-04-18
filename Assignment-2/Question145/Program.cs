using System;
using System.Linq;
using System.Collections.Generic;

namespace Question145
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static List<int> Question145(List<int> nums)
        {
            IEnumerable<int> e = nums.Select(x => 5 * (x + 2));
            return e.ToList();
        }
    }
}
