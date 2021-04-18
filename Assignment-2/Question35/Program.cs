using System;

namespace Question35
{
    class Program
    {
        static void Main(string[] args)
        {
            Question35();
        }

        static int Question35()
        {
            //string str = "abcdefgh";
            //string str1 = "abijsklm";
            //string str = "abcde";
            //string str1 = "osuefrcd";
            string str = "pqrstuvwx";
            string str1 = "pqkdiewx";

            int count = 0;
            for(int i =0; i<str.Length-1; i++)
            {
                string firstSub = str.Substring(i, 2);
                for(int j = 0; j<str1.Length-1; j++)
                {
                    string secondSub = str1.Substring(j, 2);
                    if(firstSub.Equals(secondSub))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            return count;    
        }
    }
}
