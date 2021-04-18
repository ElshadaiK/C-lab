using System;

namespace Question14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input side 1 of triangle: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input side 2 of triangle: ");
            int side2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Input side 3 of triangle: ");
            int side3 = Convert.ToInt32(Console.ReadLine());

            if (side1 == side2 && side2 == side3) {
                Console.WriteLine("Equilateral Triangle");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3) {
                Console.WriteLine("Isosceles Triangle");
            }
            else {
                Console.WriteLine("Scalene Triangle");
            }
        }
    }
}
