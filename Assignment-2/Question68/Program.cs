using System;

namespace Question68
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static string Question68(string stringOne)
        {
            return stringOne.Remove(0, 2) + stringOne.Substring(0, 2);
        }
    }
}
