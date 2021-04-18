using System;

namespace Question75
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            System.Console.Write("Enter word: ");
            word=System.Console.ReadLine();
            if (word.Length%2!=0){
                System.Console.WriteLine($"{word[(word.Length/2)-1]}{word[(word.Length/2)]}{word[(word.Length/2)+1]}");
            }
        }
    }
}
