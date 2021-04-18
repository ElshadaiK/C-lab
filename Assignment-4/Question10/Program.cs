using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Physics mark: ");
            double physics = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Chemistry mark: ");
            double chemistry = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Math mark: ");
            double math = Convert.ToDouble(Console.ReadLine());

            if (math >= 65 && physics >= 55 && chemistry >= 50) {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (math + physics + chemistry >= 180 || math + physics >= 140) {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else {
                Console.WriteLine("The candidate is NOT eligible for admission.");
            }
        }
    }
}
