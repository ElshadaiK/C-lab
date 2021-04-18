using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double D = (b * b) - (4 * a * c);
            if (D == 0) {
                double root = -b / (2 * a);
                Console.WriteLine($"Both roots are equal. They are {root}");
            }
            else if (D > 0) {
                Console.WriteLine($"Roots are real and different.");
                double root1 = (-b + Math.Sqrt(D)) / (2 * a);
                double root2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"First root is {root1}");
                Console.WriteLine($"Second root is {root2}");
            }
            else {
                Console.WriteLine($"Roots are imaginary; \n No Solution.");
            }
        }
    }
}
