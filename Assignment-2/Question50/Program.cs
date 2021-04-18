using System;

namespace Question50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(11, 21, 31));
            Console.WriteLine(test(11, 22, 31));
            Console.WriteLine(test(11, 22, 33));
            Console.ReadLine();
                
            static bool test(int x, int y, int z)
            {
                return x % 10 == y % 10 || x % 10 == z % 10 || y % 10 == z % 10;
            }
        }
    }
}
