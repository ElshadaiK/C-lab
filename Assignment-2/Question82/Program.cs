using System;

namespace Question82
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper("abc", "abcd"));
            Console.WriteLine(helper("Python", "Python"));
            Console.WriteLine(helper("JS", "Python"));

            static string helper(string str1, string str2)
            {
                if (str1.Length < str2.Length) {
                    return str1 + str2.Substring(str2.Length - str1.Length);
                }
                else if (str1.Length > str2.Length) {
                    return str1.Substring(str1.Length - str2.Length) + str2;
                }
                else {
                    return str1 + str2;
                }
            }
        }
    }
}
