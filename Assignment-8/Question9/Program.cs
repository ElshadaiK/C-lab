using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();
            
            int vowel = 0;
            int consonant = 0;
            
            foreach (char chr in input)
            {
                if (char.ToLower(chr) == 'a' || char.ToLower(chr) == 'e' || char.ToLower(chr) == 'i' || char.ToLower(chr) == 'o' || char.ToLower(chr) == 'u')
                {
                    vowel++;
                }
                else if ((chr >= 'a' && chr <= 'z') || (chr >= 'A' && chr <= 'Z')){
                    consonant++;
                }
            }

            Console.WriteLine($"Number of vowels: {vowel}");
            Console.WriteLine($"Number of consonants: {consonant}");
        }
    }
}
