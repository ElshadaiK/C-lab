using System;

namespace Question44
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            System.Console.Write("enter number: ");
            num1=int.Parse(System.Console.ReadLine());
            if ((num1%10>=8) || (num1%10<=2)){
                System.Console.Write("True");
            }
            else {
                System.Console.Write("False");
            }
        }
    }
}
