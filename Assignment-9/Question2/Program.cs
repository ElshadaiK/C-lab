using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Please input a name: ");
            string name = Console.ReadLine();
            Welcome(name);
            NiceDay();
        }

        static void Welcome(string name)
        {
            System.Console.WriteLine($"Welcome friend {name}!");
        }

        static void NiceDay()
        {
            System.Console.WriteLine("Have a nice day!");
        }
    }
}
