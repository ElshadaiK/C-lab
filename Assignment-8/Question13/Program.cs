using System;

namespace Question13
{
    class Program
    {
        static void Main(string[] args)
        {   
            int c = 0;
            Console.Write("Input the string: ");
            string str = Console.ReadLine();
            char[] arr1 = str.ToCharArray(0, str.Length);

            Console.Write("Input the position to start extraction: ");
            int pos= Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Input the length of substring: ");
            int substrLen = Convert.ToInt32(Console.ReadLine()); 
			   
            Console.Write("The substring is: ");
            while (c < substrLen) 
            {
                Console.Write(arr1[pos + c - 1]);
                c++;
            }
        }
    }
}
