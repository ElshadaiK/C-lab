using System;

namespace Question78
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper("abc", "cat"));
            Console.WriteLine(helper("python", "php"));
            Console.WriteLine(helper("php", "php"));

            static string helper(string s1, string s2)
            {
                if (s1.Length < 1)
                {
                    return s2;
                }

                if (s2.Length < 1)
                {
                    return s1;
                }

                return !s1.EndsWith(s2.Substring(0, 1)) ? s1 + s2 : s1 + s2.Substring(1);
            }
        }
    }
}
