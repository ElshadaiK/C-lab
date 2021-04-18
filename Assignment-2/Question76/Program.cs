using System;

namespace Question76
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper("Hello"));
            Console.WriteLine(helper("Python"));
            Console.WriteLine(helper("a"));
            Console.WriteLine(helper(""));

            static string helper(string s1)
            {
                if (s1.Length >= 2)
                {
                    s1 = s1.Substring(0, 2);
                }
                else if (s1.Length > 0)
                {
                    s1 = s1.Substring(0, 1) + "#";
                }
                else
                {
                    s1 = "##";
                }

                return s1;
            }
        }
    }
}
