using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string first_3_letters = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 3)
                {
                    break;
                }
                first_3_letters += input[i];
            }
            Console.WriteLine("{0}{1}{0}", first_3_letters, input);
        }
    }
}
