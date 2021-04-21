using System;

namespace Question14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();
            Console.Write("Input the substring to search: ");
            string substring = Console.ReadLine();

            if (str.Contains(substring)) {
                System.Console.WriteLine("The substring exists in the string");
            }
            else {
                System.Console.WriteLine("The substring does not exist");
            }
        }
    }
}
