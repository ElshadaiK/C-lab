using System;

namespace Question17
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            char[] temp;
            System.Console.Write("Enter a word: ");
            word= System.Console.ReadLine();

            string word1= word.ToLower();
            temp = word1.ToCharArray();
        
            if (temp[1]=='y' && temp[2]=='t'){
                for(int count=0; count<temp.Length;count++){
                    if (count!=1 && count !=2){
                        System.Console.WriteLine($"{temp[count]}");
                    }
                }
            return;
            }
            else{
                System.Console.WriteLine($"{word}");
                return;
            }
        }
    }
}
