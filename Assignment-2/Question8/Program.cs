using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper("C Sharp"));
            Console.WriteLine(helper("JS"));
            Console.WriteLine(helper("a"));

            static string helper(string str)
            {
                if (str.Length < 2) {
                    return str;
                } else {
                    return str.Substring(0,2) + str.Substring(0,2) + str.Substring(0,2)+ str.Substring(0,2);
                }
            }
        }
    }
}
