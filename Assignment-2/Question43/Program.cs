using System;

namespace Question43
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            System.Console.Write("enter number: ");
            num1=int.Parse(System.Console.ReadLine());
            if ((num1%3==0) &&(num1%7==0)){
                System.Console.Write("False");
            }
            else if ((num1%3==0) || (num1%7==0)){
                System.Console.Write("True");
            }
            else{
                System.Console.Write("False");
            }
        }
    }
}
