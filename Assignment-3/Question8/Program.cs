using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pi = (decimal)Math.PI;
            Console.Write("Input radius of the sphere: ");
            decimal radius = Convert.ToDecimal(Console.ReadLine());
            
            decimal area = 4 * pi * radius * radius;
            decimal volume = (4 / 3) * (pi * radius * radius * radius);
            Console.WriteLine($"Surface area is {area}");
            Console.WriteLine($"Volume is {volume}");
        }
    }
}
