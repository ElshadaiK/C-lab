using System;

namespace Question24
{
    class Program
    {
        static void Main(string[] args)
        {   
            double area = 0.0;
            Console.WriteLine("1 - Area of Triangle");
            Console.WriteLine("2 - Area of Rectangle");
            Console.WriteLine("3 - Area of Circle");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) {
                Console.Write("Enter the base of the triangle: ");
                double Base = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input the hight of the triangle :");
                double height = Convert.ToDouble(Console.ReadLine());
                
                area = (1 / 2) * (Base * height);
            }
            else if (choice == 2) {
                Console.Write("Enter the length of the rectangle: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the width of the rectangle: ");
                double width = Convert.ToDouble(Console.ReadLine());

                area = length * width;
            }
            else if (choice == 3) {
                Console.Write("Enter the radius of the circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                area = Math.PI * radius * radius;
            }

            Console.WriteLine($"The area of the shape is {area}");
        }
    }
}
