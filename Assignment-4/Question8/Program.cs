using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the 1st number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three");
            else
                Console.Write("The 3rd Number is the greatest among three");
        }
    }
}
