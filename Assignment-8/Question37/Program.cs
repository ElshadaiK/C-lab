using System;

namespace Question37
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] str = { "hello ", "welcome ", "to ", "C# Sharp ",
                        "create ", "Windows ", "client ", "applications "};

            Console.WriteLine(string.Concat(str));

            Array.Sort(str);
            Console.WriteLine(string.Concat(str));
        }
    }
}
