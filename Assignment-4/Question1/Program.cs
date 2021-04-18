using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input first number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(EqualOrNot(num1, num2));
        }

        static bool EqualOrNot(int num1, int num2)
        {
            if (num1 == num2) return true;
            return false;
        }
    }
}
