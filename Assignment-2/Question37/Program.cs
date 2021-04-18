using System;

namespace Question37
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static string Question37(string given_string)
        {
            var new_string = string.Empty;
            for (var i = 0; i < given_string.Length; i += 4)
            {
                var c = i + 2;
                var n = 0;
                n += c > given_string.Length ? 1 : 2;
                new_string += given_string.Substring(i, n);
            }
            return new_string;
        }
    }
}
