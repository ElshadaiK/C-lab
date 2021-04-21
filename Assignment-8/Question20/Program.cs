using System;

namespace Question20
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string findstring;
            string insertstring;
            int i;

            Console.Write("Input the original string: ");
            str1 = Console.ReadLine();
            Console.Write("Input the string to be searched for: ");
            findstring = Console.ReadLine();  
            Console.Write("Input the string to be inserted: ");
            insertstring = Console.ReadLine(); 	   

            i=str1.IndexOf(findstring);
            insertstring = insertstring.Trim() + " ";
            str1 = str1.Insert(i, insertstring);

            Console.Write("The modified string is: {0}\n",str1);
        }
    }
}
