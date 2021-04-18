using System;

namespace Question46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper("FizzBuzz"));
            Console.WriteLine(helper("Fizz"));
            Console.WriteLine(helper("Buzz"));
            Console.WriteLine(helper("Founder"));
            Console.ReadLine();

            static string helper(string str)
            {
                if (str.StartsWith("F") && str.EndsWith("B"))
                {
                    return "FizzBuzz";
                }
                else if (str.StartsWith("F"))
                {
                    return "Fizz";
                }
                else if (str.EndsWith("B"))
                {
                    return "Buzz";
                }
                else
                {
                    return str;
                }
            }
        }
    }
}
