using System;

namespace QuestionNum2
{
    class Program
    {

        public static void Main()
        {
            int j, sum = 0;

            Console.Write("\n\n");
            Console.Write("Find the sum of first 10 natural numbers:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("The first 10 natural number are :\n");
            for (j = 1; j <= 10; j++)
            {
                sum = sum + j;
                Console.Write("{0} ", j);
            }
            Console.Write("\nThe Sum is : {0}\n", sum);
        }
    }
}
