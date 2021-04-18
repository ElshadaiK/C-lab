using System;

namespace Question16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an alphabet: ");
            char alph = Convert.ToChar(Console.ReadLine().ToLower());

            if (alph == 'a' || alph == 'e' || alph == 'i' || alph == 'o' || alph == 'u') {
                Console.WriteLine("Vowel");
            }
            else {
                Console.WriteLine("Consonant");
            }
        }
    }
}
