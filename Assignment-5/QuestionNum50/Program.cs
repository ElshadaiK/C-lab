using System;

namespace QuestionNum50
{
    class Program
    {

        public static void Main()
        {
            int n, i, j, ocno = 0, dn;

            Console.Write("\n\n");
            Console.Write("Convert decimal number to octal without using array:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Enter a number to convert : ");
            n = Convert.ToInt32(Console.ReadLine());
            dn = n;
            i = 1;

            for (j = n; j > 0; j = j / 8)
            {
                ocno = ocno + (j % 8) * i;
                i = i * 10;
                n = n / 8;
            }

            Console.Write("\nThe Octal of {0} is {1}.\n\n", dn, ocno);
        }
    }
}
