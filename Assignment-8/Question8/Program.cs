using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();

            string[] copied = new string[input.Length];
            int i = 0;
            while (i < input.Length) {
                copied[i] = input[i].ToString();
                i++;
            }
            Console.WriteLine($"The first string is: {input}");
            Console.WriteLine($"The second string is: {string.Join("", copied)}");
            Console.WriteLine($"Number of characters copied: {i}");
        }
    }
}
