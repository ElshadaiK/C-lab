using System;

namespace Question33
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Goodbye";
            string str2 = "Hello";
            string str3 = "a small string";
            string str4 = "goodbye";

            Console.WriteLine(CompareStrings(str1, str1));

            Console.WriteLine(CompareStrings(str1, str2));
            Console.WriteLine(CompareStrings(str1, str3));

            Console.WriteLine(CompareStrings(str1, str4));
            Console.WriteLine(CompareStrings(str4, str1));
        }

        private static string CompareStrings( string str1, string str2 )
        {
            int cmpVal = str1.CompareTo(str2);

            if (cmpVal == 0) 
                return "The strings occur in the same position in the sort order.";
            else if (cmpVal > 0)
                return "The first string precedes the second in the sort order.";
            else
                return "The first string follows the second in the sort order.";
        }
    }
}
