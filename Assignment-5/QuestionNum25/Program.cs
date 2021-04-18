using System;

namespace QuestionNum25
{
    class Program
    {

        public static void Main()
        {
            int i, n, sum = 0;

            Console.Write("\n\n");
            Console.Write("Calculate n terms of square natural number and their sum:\n");
            Console.Write("-----------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe square natural upto {0} terms are :", n);
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0}  ", i * i);
                sum += i * i;
            }
            Console.Write("\nThe Sum of Square Natural Number upto {0} terms = {1} \n", n, sum);
        }
    }
}
