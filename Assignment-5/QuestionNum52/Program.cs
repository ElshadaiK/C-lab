using System;

namespace QuestionNum52
{
    class Program
    {

        public static void Main()
        {

            int g1, cr, j;
            int ntrm;
            double sum = 0, tn, gpn;

            Console.Write("\n\n");
            Console.Write("Find the Sum of GP series:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");


            Console.Write("Input the first number of the G.P. series: ");
            g1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the number or terms in the G.P. series: ");
            ntrm = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the common ratio of G.P. series: ");
            cr = Convert.ToInt32(Console.ReadLine());

            /*-------- generate G.P. series ---------------*/
            Console.Write("\nThe numbers for the G.P. series:\n ");
            Console.Write("1  ");

            for (j = 1; j <= ntrm; j++)
            {
                gpn = Math.Pow(cr, j);
                Console.Write("{0}  ", gpn);
            }
            /*-------- End of G.P. series generate ---------------*/


            sum = (g1 * (1 - (Math.Pow(cr, ntrm + 1)))) / (1 - cr);
            tn = g1 * (Math.Pow(cr, ntrm - 1));

            Console.Write("\nThe tn terms of G.P. : {0}\n\n", tn);
            Console.Write("\nThe Sum of the G.P. series : {0}\n\n", sum);
        }
    }
}
