using System;

namespace Question30
{
    class Program
    {
        static string Main(string[] args)
        {
            Console.Write("Enter string (abcd | abc | ab | a): ");
            string str = Console.ReadLine();
            string result = String.Empty;
            for(int i =0; i<str.Length; i++)
            {
                result+=str.Substring(0,i+1);
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
