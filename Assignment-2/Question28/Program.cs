using System;

namespace Question28
{
    class Program
    {
        static bool Main(string[] args)
        {
            //string str = "JSaaakoiaa";
            string str = "babaaccaag";
            //string str = "caabb";
            for(int i =0; i<str.Length-1; i++)
            {
                if(str.Substring(i, 1).Equals("a") && str.Substring(i, 2) != "aa")
                {
                    Console.WriteLine(false);
                    return false;
                }else if(str.Substring(i, 1).Equals("a") && str.Substring(i, 2) == "aa")
                {
                    Console.WriteLine(true);
                    return true;
                }
            }
            Console.WriteLine(false);
            return false;
        }
    }
}
