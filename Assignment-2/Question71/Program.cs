using System;

namespace Question71
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            System.Console.Write("Enter word: ");
            word=System.Console.ReadLine();
            if (word.Length%2==0){
                System.Console.WriteLine($"{word[(word.Length/2)-1]}{word[(word.Length/2)]}");
            }
            else{
                System.Console.Write("word is not even");
            }
        }
    }
}
