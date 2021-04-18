using System;

namespace QuestionNum28
{
    class Program
    {

        public static void Main()
        {
            int n, i, sum;
            int mn, mx;

            Console.Write("\n\n");
            Console.Write("Find perfect numbers within a given number of range:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the starting range or number : ");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the ending range of number : ");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Perfect numbers within the given range : ");
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.Write("\n");
        }
    }
}
