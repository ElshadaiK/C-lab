using System;
using System.Linq;

namespace HelloWorld{
    class Palindrome
    {
        public static bool checkPalindrome(string inputString)
        {
          char[] c = inputString.ToCharArray();
          Array.Reverse(c);
          return new string(c).Equals(inputString);
        }
    }
}