using System;
using System.Linq;

namespace HelloWorld{
    class SortAscending
    {
        public static int[] sort_numbers(int[] arra)
        {
     
            int[] num = arra.Where(x => x != -5).OrderBy(x => x).ToArray();
            int ctr = 0;

            return arra.Select(x => x >= 0 ? num[ctr++] : -5).ToArray();
        }

    }
}