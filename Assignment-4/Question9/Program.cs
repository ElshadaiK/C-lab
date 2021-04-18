using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0) Console.WriteLine("First Quadrant");
            else if (x < 0 && y > 0) Console.WriteLine("Second Quadrant");
            else if (x < 0 && y < 0) Console.WriteLine("Third Quadrant");
            else Console.WriteLine("Fourth Quadrant");
        }
    }
}
