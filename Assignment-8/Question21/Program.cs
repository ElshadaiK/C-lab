using System;

namespace Question21
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "computer";
            string str2 = "system";
            string str;
            int result;

            Console.WriteLine("str1 = '{0}', str2 = '{1}'", str1, str2);
            result = String.Compare(str1, 2, str2, 0, 2);
            str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
            Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(2, 2), str1);
            Console.Write("{0} ", str);
            Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(0, 2), str2);
        }
    }
}
