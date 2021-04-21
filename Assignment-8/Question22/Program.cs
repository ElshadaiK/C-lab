using System;

namespace Question22
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "COMPUTER";
            string str2 = "computer";
            string str;
            int result;

            Console.WriteLine();
            Console.WriteLine("str1 = '{0}', str2 = '{1}'", str1, str2);
            Console.WriteLine("Ignore case:");
            result = String.Compare(str1, 2, str2, 2, 2, true);
            str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
            Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(2, 2), str1);
            Console.Write("{0} ", str);
            Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(2, 2), str2);

            Console.WriteLine();
            Console.WriteLine("Honor case:");
            result = String.Compare(str1, 2, str2, 2, 2, false);
            str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
            Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(2, 2), str1);
            Console.Write("{0} ", str);
            Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(2, 2), str2);
        }
    }
}
