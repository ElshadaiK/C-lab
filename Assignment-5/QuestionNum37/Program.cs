using System;

namespace QuestionNum37
{
    class Program
    {

        public static void Main()
        {
            int num, r, sum = 0, t;

            Console.Write("\n\n");
            Console.Write("Display the number in reverse order:\n");
            Console.Write("--------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; t != 0; t = t / 10)
            {
                r = t % 10;
                sum = sum * 10 + r;
            }
            Console.Write("The number in reverse order is : {0} \n", sum);
        }
    }
}
