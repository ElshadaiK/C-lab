using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0 || number % 7 == 0) {
                Console.WriteLine(true);
            } else {
                Console.WriteLine(false);
            }
        }
    }
}
