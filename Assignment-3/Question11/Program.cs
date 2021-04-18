using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string binary = "";
            while (num > 1) {
                int remainder = num % 2;
                binary = Convert.ToString(remainder) + binary;
                num /= 2;
            }
            binary = Convert.ToString(num) + binary;
            Console.WriteLine("Binary: {0}",binary);
        }
    }
}
