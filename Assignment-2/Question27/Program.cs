using System;

namespace Question27
{
    class Program
    {
        static int Main(string[] args)
        {
            //string s = "JSaaakoiaa";
            string str = "bbaaccaag";
            int count = 0;
            for(int i =0; i<str.Length-1; i++)
            {
                if(str.Substring(i, 2).Equals("aa"))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
    }
}
