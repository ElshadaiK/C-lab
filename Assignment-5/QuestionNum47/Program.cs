using System;

namespace QuestionNum47
{
    class Program
    {

        public static void Main()
        {
            int i, n, n1, s1 = 0, j;
            int fact;

            Console.Write("\n\n");
            Console.Write("Check whether a number is Strong Number or not:\n");
            Console.Write("-------------------------------------------------");
            Console.Write("\n\n");

            /* If sum of factorial of digits is equal to original number then it is Strong number */

            Console.Write("Input a number to check whether it is Strong number: ");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;

            for (j = n; j > 0; j = j / 10)
            {

                fact = 1;
                for (i = 1; i <= j % 10; i++)
                {
                    fact = fact * i;
                }
                s1 = s1 + fact;

            }

            if (s1 == n1)
            {
                Console.Write("\n{0} is Strong number.\n\n", n1);
            }
            else
            {
                Console.Write("\n{0} is not Strong number.\n\n", n1);
            }
        }
    }
}
