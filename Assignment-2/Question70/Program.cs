using System;

namespace Question70
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static string Question70(string stringOne)
        {
            return stringOne.Length < 2 ? String.Empty : stringOne.Substring(1, stringOne.Length - 2);
        }
    }
}
