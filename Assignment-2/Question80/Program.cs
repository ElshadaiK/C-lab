using System;

namespace Question80
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            if (input.StartsWith("abc"))
            {
                Console.WriteLine("abc");
            }
            else if (input.StartsWith("xyz"))
            {
                Console.WriteLine("xyz");
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
    }
}
