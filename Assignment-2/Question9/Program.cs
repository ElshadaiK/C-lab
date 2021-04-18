using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper("Red"));
            Console.WriteLine(helper("Green"));
            Console.WriteLine(helper("1"));

            static string helper(string str)
            {
                return str.Substring(str.Length - 1) + str.Substring(0, str.Length) + str.Substring(str.Length - 1);
            }
        }
    }
}
