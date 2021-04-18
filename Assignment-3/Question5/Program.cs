using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            System.Console.WriteLine($"Permimeter of Circle: {perimeter}");
            Console.WriteLine($"Area of Circle: {area}");
        }
    }
}
