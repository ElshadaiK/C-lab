using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcd";
            string str2 = "a";
            string str3 = "xy";

            Console.WriteLine(helper(str1));
            Console.WriteLine(helper(str2));
            Console.WriteLine(helper(str3));

            static string helper(string str) 
            {
                if (str.Length == 1) {
                    return str;
                } else {
                    return str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0,1);
                }
            }
        }
    }
}
