using System;

namespace Question15
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

            Console.WriteLine((num1 < 51 && num1 > 19) || (num2 < 51 && num2 > 19) || (num3 < 51 && num3 > 19));
        }
    }
}
