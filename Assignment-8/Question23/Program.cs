using System;
using System.Globalization;

namespace Question23
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "COMPUTER";
            string str2 = "computer";
            string str;
            int result;

            Console.WriteLine("\nstr1 = '{0}', str2 = '{1}'", str1, str2);
            Console.WriteLine("Ignore case, Turkish culture:");
            result = String.Compare(str1, 4, str2, 4, 2, true, new CultureInfo("tr-TR"));
            str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
            Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(4, 2), str1);
            Console.Write("{0} ", str);
            Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(4, 2), str2);

            Console.WriteLine();
            Console.WriteLine("Ignore case, invariant culture:");
            result = String.Compare(str1, 4, str2, 4, 2, true, CultureInfo.InvariantCulture);
            str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
            Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(4, 2), str1);
            Console.Write("{0} ", str);
            Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(4, 2), str2);
        }
    }
}
