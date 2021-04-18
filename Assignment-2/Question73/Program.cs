using System;

namespace Question73
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static string Question73(string s1,int n)
        {
            return s1.Substring(0, n) + s1.Substring(s1.Length - n);
        }
    }
}
