using System;

namespace Question48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(1, 2, 3));
            Console.WriteLine(helper(4, 5, 6));
            Console.WriteLine(helper(-1, 1, 0));
            Console.ReadLine();

            static bool helper(int x, int y, int z)
            {
                return x < y && y < z;
            }
        }
    }
}
