using System;

namespace Question77
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper("Hello", "Hi"));
            Console.WriteLine(helper("Python", "PHP"));
            Console.WriteLine(helper("JS", "JS"));
            Console.WriteLine(helper("Csharp", ""));

            static string helper(string s1, string s2)
            {
                string lastChars = String.Empty;

                if (s1.Length > 0)
                {
                    lastChars += s1.Substring(0, 1);
                }
                else
                {
                    lastChars += "#";
                }

                if (s2.Length > 0)
                {
                    lastChars += s2.Substring(s2.Length - 1);
                }
                else
                {
                    lastChars += "#";
                }

                return lastChars;
            }
        }
    }
}
