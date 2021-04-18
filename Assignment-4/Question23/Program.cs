using System;

namespace Question23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a month number: ");
            int monthNum = Convert.ToInt32(Console.ReadLine());

            if (monthNum == 2) Console.WriteLine("Month has 28 days.");
            else if (monthNum == 4 || monthNum == 6 || monthNum == 9 || monthNum == 11) {
                Console.WriteLine("Month has 30 days.");
            }
            else {
                Console.WriteLine("Month as 31 days.");
            }
        }
    }
}
