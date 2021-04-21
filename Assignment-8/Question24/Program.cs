using System;
using System.Globalization;

namespace Question24
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "John Peterson";
            string name2 = "Michel Jhonson";

            int index1 = name1.IndexOf(" ");
            index1 = index1 < 0 ? 0 : index1--;

            int index2 = name2.IndexOf(" ");
            index2 = index2 < 0 ? 0 : index2--;

            int length = Math.Max(name1.Length, name2.Length);

            Console.WriteLine("Sorted alphabetically by last name:");
            if (String.Compare(name1, index1, name2, index2, length, 
                                new CultureInfo("en-US"), CompareOptions.IgnoreCase) < 0)
                Console.WriteLine("{0}\n{1}", name1, name2); 
            else
                Console.WriteLine("{0}\n{1}", name2, name1); 
        }
    }
}
