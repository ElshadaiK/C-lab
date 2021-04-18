using System;

namespace QuestionNum7
{
    class Program
    {

        public static void Main()
        {
            int j, i, n;
            Console.Write("\n\n");
            Console.Write("Display the multiplication table vertically from 1 to n:\n");
            Console.Write("---------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input upto the table number starting from 1 : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Multiplication table from 1 to {0} \n", n);
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (j <= n - 1)
                        Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                    else
                        Console.Write("{0}x{1} = {2}", j, i, i * j);

                }
                Console.Write("\n");
            }
        }
    }
}
