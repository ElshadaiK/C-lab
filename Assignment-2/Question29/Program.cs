using System;

namespace Question29
{
    class Program
    {
        static string Main(string[] args)
        {
            //string str = "PHP";
            string str = "Python";
            //string str = "JS";
            string result = String.Empty;
            for(int i =0; i<str.Length; i++)
            {
                if(i%2==0)
                {
                    result+=str[i];
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
