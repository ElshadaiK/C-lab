using System;

namespace Question24
{
    class Program
    {
        static void Main(string[] args)
        {
            Question24("Hello");
            static string Question24(string str)
            {
            return str.Length < 3 ? str.ToUpper() : str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
            }
        }
    }
}
