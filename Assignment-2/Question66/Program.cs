using System;

namespace Question66
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static string Question66(string stringOne, string stringTwo)
        {
            return stringOne.Length < stringTwo.Length ? stringTwo + stringOne + stringTwo : stringOne + stringTwo + stringOne;
        }
    }
}
