using System;

namespace QuestionNum21
{
    class Program
    {

        public static void Main()
        {
            int n, i, t = 9;
            int sum = 0;

            Console.Write("\n\n");
            Console.Write("Display the sum of the series [ 9 + 99 + 999 + 9999 ...]:\n");
            Console.Write("-----------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number or terms :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                sum += t;
                Console.Write("{0}   ", t);
                t = t * 10 + 9;
            }
            Console.Write("\nThe sum of the saries = {0} \n", sum);
        }
    }
}
