using System;

namespace Question63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Question63());
        }
        static string Question63()
        {
            string str = "Hello";
            //string str = "Hi";
            //string str = "H";
            //string str = " ";

            return str.Length>1 ? str.Substring(0,2) : str; 

        }
    }
}
