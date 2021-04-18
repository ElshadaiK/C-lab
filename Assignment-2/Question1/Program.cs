using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers");
            Console.Write("Enter Number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 == num2 ? (num1 + num2) * 3 : (num1 + num2));
        }
    }
}
