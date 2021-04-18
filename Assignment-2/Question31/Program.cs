using System;

namespace Question31
{
    class Program
    {
        static int Main(string[] args)
        {
            string str = "abcdsab";
            //string str = "abcdabab";
            //string str = "abcabdabab";
            //string str = "abcabd";
            string lastChars = str.Substring(str.Length-2);
            int count = 0;
            for(int i =0; i<str.Length-2; i++)
            {
                if(str.Substring(i, 2).Equals(lastChars))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
    }
}
