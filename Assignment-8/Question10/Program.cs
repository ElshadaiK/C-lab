using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Max occurring character is " +
                            GetMaxOccuringChar(input));
        }
        static char GetMaxOccuringChar(string str)
        {
            int[] count = new int[256];

            int len = str.Length;
            for (int i = 0; i < len; i++)
                count[str[i]]++;
        
            int max = -1; 
            char result = ' '; 

            for (int i = 0; i < len; i++) {
                if (max < count[str[i]]) {
                    max = count[str[i]];
                    result = str[i];
                }
            }
        
            return result;
        }
    }
}
