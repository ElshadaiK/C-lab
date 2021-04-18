using System;

namespace Question23
{
    class Program
    {
        static void Main(string[] args)
        {
            Question23(5, 7);
            static bool Question23(int x, int y)
        {
            return Math.Abs(x % 10) == Math.Abs(y % 10);
        }
        }
    }
}
