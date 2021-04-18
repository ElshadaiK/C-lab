using System;

namespace QuestionNum48
{
    class Program
    {

        public static void Main()
        {
            int i, n1, s1 = 0, j, k, en, sn;
            int fact;

            Console.Write("\n\n");
            Console.Write("Find Strong Numbers within a range of numbers:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");


            /* If sum of factorial of digits is equal to original number then it is Strong number */

            Console.Write("Input starting range of number : ");
            sn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending range of number: ");
            en = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nThe Strong numbers are :\n");

            for (k = sn; k <= en; k++)
            {
                n1 = k;
                s1 = 0;

                for (j = k; j > 0; j = j / 10)
                {

                    fact = 1;
                    for (i = 1; i <= j % 10; i++)
                    {
                        fact = fact * i;
                    }
                    s1 = s1 + fact;
                }

                if (s1 == n1)

                    Console.Write("{0}  ", n1);
            }
            Console.Write("\n\n");
        }
    }
}
