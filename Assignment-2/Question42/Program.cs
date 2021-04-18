using System;

namespace Question42
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            System.Console.Write("enter num1");
            num1=int.Parse(System.Console.ReadLine());
            if ((num1%13==0) || (num1%13==1)){
                System.Console.Write("True");
                return;
            }
            else {
                System.Console.Write("False");
                return;
            }
        }
    }
}
