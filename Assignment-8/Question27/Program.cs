using System;
using System.Globalization;

namespace Question27
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "change";
            string str2 = "dollar";
            string relation = null;

            relation = symbol( String.Compare(str1, str2, false, new CultureInfo("en-US")) );
            Console.WriteLine("\nFor en-US: {0} {1} {2}", str1, relation, str2);

            relation = symbol( String.Compare(str1, str2, false, new CultureInfo("cs-CZ")) );
            Console.WriteLine("For cs-CZ: {0} {1} {2}", str1, relation, str2);
            }

            private static string symbol(int r) {
                string s = "=";
                if      (r < 0) s = "<";
                else if (r > 0) s = ">";
                return s;
                }
    }
}
