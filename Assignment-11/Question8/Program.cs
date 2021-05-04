using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            if (IsPalindrome(str))
            {
                Console.WriteLine("The string is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a Palindrome.");
            }
        }

        static bool IsPalindrome(string str)
        {
            if (str.Length <= 1)
                return true;
            else
            {
                if (str[0] != str[str.Length - 1])
                    return false;
                else
                    return IsPalindrome(str.Substring(1, str.Length-2));
            }   
        }   
    }
}
