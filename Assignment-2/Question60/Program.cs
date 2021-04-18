using System;

namespace Question60
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter two Strings");
            System.Console.Write("Enter the first String ");
            string s1 = Console.ReadLine();
            System.Console.Write("Enter the Second String ");
            string s2 = Console.ReadLine();

            Console.WriteLine($"Result {helper(s1, s2)}");


            static string helper(string st1, string st2)
            {
                return st2 + " " + st1 + " " + st1 + " " + st2;
            }
        }
    }
}
