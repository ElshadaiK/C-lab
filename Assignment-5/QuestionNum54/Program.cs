using System;

namespace QuestionNum54
{
    class Program
    {

        public static void Main()
        {


            int n1, n5, p = 1;
            int dec = 0, i = 1, j, d;
            int binno = 0;

            Console.Write("\n\n");
            Console.Write("Convert Octal to Binary:\n");
            Console.Write("--------------------------");
            Console.Write("\n\n");


            Console.Write("Input an octal number (using digit 0 - 7) :");
            n1 = Convert.ToInt32(Console.ReadLine());
            n5 = n1;



            for (j = n1; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 8;

                dec = dec + (d * p);
                i++;
            }

            /*------------------------------------------------------------------------------*/
            i = 1;

            for (j = dec; j > 0; j = j / 2)
            {
                binno = binno + (dec % 2) * i;
                i = i * 10;
                dec = dec / 2;
            }

            Console.Write("\nThe Octal Number : {0}\nThe equivalent Binary  Number : {1} \n\n", n5, binno);
        }
    }
}
