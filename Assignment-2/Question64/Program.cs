using System;

namespace Question64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Question64());
        }

        static string Question64()
        {
            //string str = "Hello";
            string str = "Hi";

            return str.Length>1 ? str.Substring(0, str.Length/2) : str;

        }
    }
}
