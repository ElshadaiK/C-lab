using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a string: ");
            string str = Console.ReadLine();
            System.Console.WriteLine($"{str} has {CountSpaces(str)} spaces.");
        }

        static int CountSpaces(string str)
        {   
            int count = 0;
            foreach (char chr in str)
            {
                if (chr == ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
