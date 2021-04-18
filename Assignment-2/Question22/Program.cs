using System;

namespace Question22
{
    class Program
    {
        static void Main(string[] args)
        {   
            Question22("Hi");
            static bool Question22(string str)
        {
            int ctr = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'z')
                {
                    ctr++;
                }
            }

            return ctr > 1 && ctr < 4;
        }
        }
    }
}
