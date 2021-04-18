using System;

namespace Question72
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            System.Console.Write("Enter word: ");
            word=System.Console.ReadLine();
            string thism=word.Substring(word.Length - 2);
            if (thism=="on"){
                System.Console.WriteLine("True");
            }
            else{
                System.Console.WriteLine("False"); 
            }
        }
    }
}
