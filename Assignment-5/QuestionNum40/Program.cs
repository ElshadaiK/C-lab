using System;

namespace QuestionNum40
{
    class Program
    {

        public static void Main()
        {
            int i, j;
            char alph = 'A';
            int n;
            int ctr = 1;

            Console.Write("\n\n");
            Console.Write("Display the pattern like pyramid using the alphabet:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number of Letters (less than 26) in the Pyramid : \n");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 0; j <= (ctr / 2); j++)
                {
                    Console.Write("{0} ", alph++);
                }
                alph--;
                alph--;

                for (j = 0; j < (ctr / 2); j++)
                {
                    Console.Write("{0} ", alph--);
                }
                ctr = ctr + 2;
                alph = 'A';
                Console.Write("\n");
            }
        }
    }
}
