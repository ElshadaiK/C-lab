using System;

namespace QuestionNum51
{
    class Program
    {

        public static void Main()
        {
            int n1, n5, p = 1, k, ch = 1;
            int dec = 0, i = 1, j, d;

            Console.Write("\n\n");
            Console.Write("Convert Octal number to Decimal number:\n");
            Console.Write("------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input an octal number (using digit 0 - 7) :");
            n1 = Convert.ToInt32(Console.ReadLine());
            n5 = n1;

            for (; n1 > 0; n1 = n1 / 10)
            {
                k = n1 % 10;
                if (k >= 8)
                {
                    ch = 0;
                }
            }

            switch (ch)
            {
                case 0:
                    Console.Write("\nThe number is not an octal number. \n\n");
                    break;
                case 1:
                    n1 = n5;
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
                    Console.Write("\nThe Octal Number : {0}\nThe equivalent Decimal  Number : {1} \n\n", n5, dec);
                    break;
            }
        }
    }
}
