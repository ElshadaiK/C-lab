using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter letter: ");
            char letter1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter letter: ");
            char letter2 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter letter: ");
            char letter3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"{ letter3} { letter2} { letter1}");
        }
    }
}
