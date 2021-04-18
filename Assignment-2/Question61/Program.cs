using System;

namespace Question61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Question61());
        }

        static string Question61()
        {
            //string str = "[[]]";
            //string str1 = "Hello";
            string str = "(())";
            string str1 = "Hi";

            return str.Substring(0, str.Length/2) + str1 + str.Substring(str.Length/2, str.Length-2);

        }
    }
}
