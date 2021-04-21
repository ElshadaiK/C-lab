using System;

namespace Question40
{
    class Program
    {
        static void Main(string[] args)
        {
            string strSource = "Python";
            char [] destination = { 'w', '3', 'r', 'e', 's', 'o', 'u', 'r', 'c', 'e', ' ', 'C',
                    'S', 'h', 'a', 'r', 'p', ' ', 'T', 'u', 't', 'o', 'r', 'i', 'a', 'l' };

            Console.WriteLine( destination );

            strSource.CopyTo ( 0, destination, 11, strSource.Length );
            Console.WriteLine( destination );
            strSource = "A different string";
            strSource.CopyTo ( 2, destination, 10, 9 );

            Console.WriteLine( destination );
        }
    }
}
