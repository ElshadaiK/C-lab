using System;

namespace Question83
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper("abc"));
            Console.WriteLine(helper("Python"));
            Console.WriteLine(helper("J"));

            static string helper(string str) 
            {
                if (str.Length < 2) {
                    return str + str + str;
                }
                return str.Substring(0,2) + str.Substring(0,2) + str.Substring(0,2);
            }
        }
    }
}
