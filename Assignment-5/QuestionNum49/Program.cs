using System;

namespace QuestionNum49
{
    class Program
    {

        public static void Main()
        {

            int n1, df, n2, i, ln;
            int s1 = 0;

            Console.Write("\n\n");
            Console.Write("Find out the sum of in A.P. series:\n");
            Console.Write("-------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input  the starting number of the A.P. series: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the number of items for  the A.P. series: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input  the common difference of A.P. series: ");
            df = Convert.ToInt32(Console.ReadLine());

            s1 = (n2 * (2 * n1 + (n2 - 1) * df)) / 2;
            ln = n1 + (n2 - 1) * df;
            Console.Write("\nThe Sum of the  A.P. series are : \n");

            for (i = n1; i <= ln; i = i + df)
            {
                if (i != ln)
                    Console.Write("{0} + ", i);
                else
                    Console.Write("{0} = {1} \n\n", i, s1);
            }
        }
    }
}
