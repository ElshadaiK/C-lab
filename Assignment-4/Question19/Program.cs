using System;

namespace Question19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the grade: ");
            char grade = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (grade) 
            {
                case 'E':
                    Console.WriteLine("Excellent");
                    break;
                case 'V':
                    Console.WriteLine("Very Good");
                    break;
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'A':
                    Console.WriteLine("Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
