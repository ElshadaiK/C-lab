using System;
using System.Linq;

namespace Question86
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper("abcab"));
            Console.WriteLine(helper("python"));
            Console.WriteLine(helper("press"));
            Console.WriteLine(helper("jythona"));

            static string helper(string str)
            {
                if (str[0] == 'a' || str.Last() == 'a')
                {
                    return str.Substring(1, str.Length - 2);
                }
                return str;
            }
        }
    }
}
