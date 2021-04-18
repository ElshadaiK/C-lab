using System;

namespace QuestionNum26
{
    class Program
    {

        public static void Main()
        {
            int n, i, sum = 0;
            int t = 1;

            Console.Write("\n\n");
            Console.Write("Calculate the sum of the series 1 +11 + 111 + 1111 + .. n terms:\n");
            Console.Write("------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the numbe of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} + ", t);
                sum = sum + t;
                t = (t * 10) + 1;
            }
            Console.Write("\nThe Sum is : {0}\n", sum);
        }
    }
}
