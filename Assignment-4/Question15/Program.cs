using System;

namespace Question15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input angle 1 of triangle: ");
            double angle1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input angle 2 of triangle: ");
            double angle2 = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Input angle 3 of triangle: ");
            double angle3 = Convert.ToDouble(Console.ReadLine());

            double totalAngle = angle1 + angle2 + angle3;
            if (totalAngle == 180) {
                Console.WriteLine("The triangle can be formed.");
            }
            else {
                Console.WriteLine("The triangle can NOT be formed.");
            }
        }
    }
}
