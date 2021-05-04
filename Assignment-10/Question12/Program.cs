using System;

namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 123456;
            Console.WriteLine("Original integer value: " + n);
            Console.WriteLine(IsPalindrome(n));
            n = 16461;
            Console.WriteLine("Original integer value: " + n);
            Console.WriteLine(IsPalindrome(n));
            n = -121;
            Console.WriteLine("Original integer value: " + n);
            Console.WriteLine(IsPalindrome(n));
        }
        static bool IsPalindrome(int a)
        {
            if (a < 0) { return false; }
            if (a < 10) { return true; }

            var temp = a;
            var b = 0;
            var digit = 0;
            while (temp != 0)
            {
                digit = temp % 10;
                b = b * 10 + digit;
                temp /= 10;
            }
            return a == b;
        }
    }
}
