using System;

namespace Question85
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper("abcab"));
            Console.WriteLine(helper("python"));
            Console.WriteLine(helper("press"));
            Console.WriteLine(helper("jython"));

            static string helper(string str)
            {   
                if (str[0] == 'p' && str[1] == 'y') return str;
                if (str[0] == 'p' && str[1] != 'y') return str.Remove(1,1);
                if (str[0] != 'p' && str[1] == 'y') return str.Remove(0,1);
                if (str[0] != 'p' && str[1] != 'y') return str.Remove(0,2);
                return str;
            }
        }
    }
}
