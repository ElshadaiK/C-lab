using System;

namespace Question65
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Question65());
        }
        static string Question65()
        {
            //string str = "Hello";
            //string str = "Hi";
            string str = "Python";
            return str.Length > 1 ? str.Substring(1, str.Length-2) : str;
        }
    }
}
