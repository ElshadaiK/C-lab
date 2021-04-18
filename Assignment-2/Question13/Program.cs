using System;

namespace Question13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first temprature: ");
            int temp1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second temprature: ");
            int temp2 = int.Parse(Console.ReadLine());

            Console.WriteLine((temp1 > 100 || temp2 > 100 ) && (temp1 < 0 || temp2 < 0));
        }
    }
}
