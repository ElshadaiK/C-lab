using System;

namespace Question62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Question62());
        }

        static string Question62()
        {
            //string str = "Hello";
            string str = "Hi";

            return str.Length > 1 ? str.Substring(str.Length-2, 2) + str.Substring(str.Length-2, 2) +  str.Substring(str.Length-2, 2) : str;
        }
    }
}
