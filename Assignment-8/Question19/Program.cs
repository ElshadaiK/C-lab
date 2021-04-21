using System;

namespace Question19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the original string : ");
            string str = Console.ReadLine();
            Console.Write("Input the string to be searched for : ");
            string toBeSearched = Console.ReadLine();

            int start = 0;
            int count = -1;
            int index = -1;

            while (start != -1)
            {
                start = str.IndexOf(toBeSearched, index + 1);
                count++;
                index = start;
            }

            System.Console.WriteLine($"The string '{toBeSearched}' occurs {count} times.");
        }
    }
}
