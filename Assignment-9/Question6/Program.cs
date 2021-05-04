using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Swap(ref num1, ref num2);
            System.Console.WriteLine();
            System.Console.WriteLine("After Swapping: ");
            System.Console.WriteLine($"Num1: {num1} Num2: {num2}");
        }

        static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
