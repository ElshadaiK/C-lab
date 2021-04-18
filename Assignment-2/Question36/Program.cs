using System;

namespace Question36
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static string Question36(string given_string, string character)
        {
            for (int i = given_string.Length - 2; i > 0; i--)
            {
                if (given_string[i] == character[0])
                {
                    given_string = given_string.Remove(i, 1);
                }
            }

            return given_string;
        }
    }
}
