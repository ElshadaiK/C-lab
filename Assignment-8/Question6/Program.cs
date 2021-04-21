using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Input the second string: ");
            string str2 = Console.ReadLine();

            if (strLen(str1) == strLen(str2)) {
                Console.WriteLine("The length of both strings are equal.");
            }
            else if(str1 == str2) {
                Console.WriteLine("Both strings are equal.");
            }
            else if(strLen(str1) == strLen(str2) && str1 == str2) {
                Console.WriteLine("The length of both strings are equal and also, both strings are equal.");
            }
            else {
                Console.WriteLine("Strings are not equal.");
            }
        }
        static int strLen(string str)
        {   
            int count = 0;
            foreach (char chr in str) {
                count++;
            }
            return count;
        }
    }
}
