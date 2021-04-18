using System;

namespace Question26
{
    class Program
    {
        static string Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.Write("Enter repetition number: ");
            int num = int.Parse(Console.ReadLine());
            string result = String.Empty;
            for(int i =0; i<num; i++)
            {
                if(str.Length < 3)
                    result+=str;
                else
                    result+=str.Substring(0,3);
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
