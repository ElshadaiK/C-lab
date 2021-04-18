using System;

namespace QuestionNum46
{
    class Program
    {

        public static void Main()
        {
            int n1, n;
            double dec = 0, i = 0, d;

            Console.Write("\n\n");
            Console.Write("Convert a binary number into decimal using math function:\n");
            Console.Write("-----------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input  the binary number :");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;
            while (n != 0)
            {
                d = n % 10;
                dec = dec + d * Math.Pow(2, i);
                n = n / 10;
                i++;
            }
            Console.Write("\nThe Binary Number : {0}\nThe equivalent Decimal  Number is : {1}\n\n", n1, dec);
        }
    }
}
