using System;

namespace Question69
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static string Question69(string stringOne)
        {
            return stringOne.Substring(stringOne.Length - 2) + stringOne.Remove(stringOne.Length - 2);
        }
    }
}
