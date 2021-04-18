using System;

namespace QuestionNum24
{
    class Program
    {

        public static void Main()
        {
            double x, sum, ctr, p, term;
            int i, n;
            Console.Write("\n\n");
            Console.Write("Calculate the sum of the series [ x - x^3 + x^5 - x^7 + x^9 - .....]:\n");
            Console.Write("------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the value of x :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            term = 1;
            sum = 0;
            for (i = 1, p = 1; i < n + 1; i++)
            {
                ctr = Math.Pow(x, p);
                sum = sum + ctr * term;
                term = term * (-1);
                p = p + 2;
            }
            Console.Write("\nThe sum = {0}\nNumber of terms = {1}\n The value of x = {2}\n", sum, n, x);
        }
    }
}
