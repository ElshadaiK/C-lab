using System;

namespace Question47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 + num2 == num3);
        }
    }
}
