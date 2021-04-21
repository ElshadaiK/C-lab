using System;

namespace Question38
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Kill two birds with one stone";
            string str2 = "birds";
            bool x = str1.Contains(str2);
            Console.WriteLine("'{0}' is in the string '{1}': {2}",
                                str2, str1, x);
            if (x) {
                int index = str1.IndexOf(str2);
                if (index >= 0)
                    Console.WriteLine("'{0} begins at character position {1}",
                                    str2, index + 1);
            }
        }
    }
}
