using System;

namespace Question31
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "JAVA";
            string str2 = "python";
            string str;
            int result;

            Console.WriteLine("Compare the numeric values of the corresponding Char objects in each string.");
            Console.WriteLine("str1 = '{0}', str2 = '{1}'", str1, str2);
            result = String.CompareOrdinal(str1, str2);
            str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
            Console.Write("String '{0}' is ", str1);
            Console.Write("{0} ", str);
            Console.WriteLine("String '{0}'.", str2);
        }
    }
}
