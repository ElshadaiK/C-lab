using System;

namespace Question87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper("abcab"));
            Console.WriteLine(helper("python"));
            Console.WriteLine(helper("press"));
            Console.WriteLine(helper("aaythona"));

            static string helper(string str)
            {
                return str.Substring(0, 2) == "aa" ? str.Substring(2) : ((str.Substring(0, 1) == "a") ? str.Substring(1) : str);
            }
        }
    }
}
