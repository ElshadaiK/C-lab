using System;

namespace Question14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine((num1 < 201 && num1 >99) && (num2 < 201 && num2 > 99));
        }
    }
}
