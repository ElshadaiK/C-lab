using System;

namespace QuestionNum58
{
    class Program
    {

        public static void Main()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'A' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 7; row++)
            {
                for (column = 0; column <= 7; column++)
                {
                    if (((column == 1 || column == 5) && row != 0) ||
                         ((row == 0 || row == 3) && (column > 1 && column < 5)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
