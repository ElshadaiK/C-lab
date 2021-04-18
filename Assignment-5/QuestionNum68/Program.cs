using System;

namespace QuestionNum68
{
    class Program
    {

        public static void Main()
        {
            int row, column, j = 5, i = 0;
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'K' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == column + 1) && column != 0))
                        Console.Write("*");

                    else if (row == i && column == j)
                    {
                        Console.Write("*");
                        i = i + 1;
                        j = j - 1;
                    }
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
