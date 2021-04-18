using System;

namespace Question81
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper("abab"));
            Console.WriteLine(helper("abcdef"));
            Console.WriteLine(helper("xyzsderxy"));

            static bool helper(string str)
            {
                if (str.Substring(0,2) == str.Substring(str.Length - 2)) return true;
                return false;
            }
        }
    }
}
