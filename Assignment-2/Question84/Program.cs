using System;

namespace Question84
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper("abcab"));
            Console.WriteLine(helper("Python"));

            static string helper(string str)
            {
                if (str.Substring(0,2) == str.Substring(str.Length - 2)) {
                    return str.Substring(2);
                } else return str;
            }
        }
    }
}
