using System;

namespace Question25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose Operation");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Substraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) {
                double sum = num1 + num2;
                Console.WriteLine($"The sum is {sum}");
            }
            else if (choice == 2) {
                double diff = num1 - num2;
                Console.WriteLine($"The difference is {diff}");
            }
            else if (choice == 3) {
                double product = num1 * num2;
                Console.WriteLine($"The product is {product}");
            }
            else if (choice == 4) {
                if (num2 == 0) Console.WriteLine($"Can not divide by zero");
                else {
                    double quotient = num1 / num2;
                    Console.WriteLine($"The quotient is {quotient}");
                }
            }
            else if (choice == 5) Console.WriteLine("Thank you for using my calculator");
        }
    }
}
