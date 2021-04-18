using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            for (y=-5; y <= 5; y++)
            {
            x = y*y - 2*y + 1;
            Console.WriteLine(
                "x=({0})² - 2*({0}) + 1 = {1}",
                y, x);
            }
        }
    }
}
