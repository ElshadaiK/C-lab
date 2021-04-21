using System;
using System.Globalization;

namespace Question42
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Search for the target string \"{0}\" in the string \"{1}\".\n";
            string str2 = "Using the {0} - \"{1}\" culture:";
            string str3 = "  The string to search ends with the target string: {0}";
            bool result = false;
            CultureInfo ci;

            string capitalARing = "\u00c5";
            string abcARing = "abc" + "\u0419\u0809";

            Console.Clear();
            Console.WriteLine(str1, capitalARing, abcARing);

            ci = new CultureInfo("en-GB");
            Console.WriteLine(str2, ci.DisplayName, ci.Name);

            Console.WriteLine("Case sensitive:");
            result = abcARing.EndsWith(capitalARing, false, ci);
            Console.WriteLine(str3, result);

            Console.WriteLine("Case insensitive:");
            result = abcARing.EndsWith(capitalARing, true, ci);
            Console.WriteLine(str3, result);
            Console.WriteLine();

            ci = new CultureInfo("en-AU");
            Console.WriteLine(str2, ci.DisplayName, ci.Name);

            Console.WriteLine("Case sensitive:");
            result = abcARing.EndsWith(capitalARing, false, ci);
            Console.WriteLine(str3, result);

            Console.WriteLine("Case insensitive:");
            result = abcARing.EndsWith(capitalARing, true, ci);
            Console.WriteLine(str3, result);
        }
    }
}
