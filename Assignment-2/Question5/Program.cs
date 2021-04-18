using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string :");
            string s = Console.ReadLine();
            Console.WriteLine($"Result: {helper(s)}");


            static string helper(string s)
            {
                return s.Substring(0, 2) == "if " ? s : "if" + s;
            }
        }
    }
}
