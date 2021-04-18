using System;

namespace QuestionNum39
{
    class Program
    {

        public static void Main()
        {
            int i, sum = 0;

            Console.Write("\n\n");
            Console.Write("Find the number and sum of all integer between 100 and 200, divisible by 9:\n");
            Console.Write("-----------------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Numbers between 100 and 200, divisible by 9 : \n");
            for (i = 101; i < 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write("{0}  ", i);
                    sum += i;
                }
            }
            Console.Write("\n\nThe sum : {0} \n", sum);
        }
    }
}
