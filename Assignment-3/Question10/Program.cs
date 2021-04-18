using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0 && num2 % 2 == 0) Console.WriteLine(true);
            else Console.WriteLine(false);
        }
    }
}
