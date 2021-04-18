using System;

namespace Question74
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int index1;
            System.Console.Write("Enter word: ");
            word=System.Console.ReadLine();
            System.Console.Write("Enter index: ");
            index1=int.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"{word[index1]}{word[index1+1]}");
        }
    }
}
