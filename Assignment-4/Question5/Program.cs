using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18) Console.WriteLine("You are eligible to vote.");
            else Console.WriteLine("You are not eligible to vote.");
        }
    }
}
