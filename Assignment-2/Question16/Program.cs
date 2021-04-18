using System;

namespace Question16
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            System.Console.Write("enter num1");
            num1=int.Parse(System.Console.ReadLine());
            System.Console.Write("enter num2");
            num2=int.Parse(System.Console.ReadLine());
            if ((20<=num1 && num1<=50)|| (20<=num2 && num2<=50)){
                System.Console.WriteLine("True");
                return;
            }
            else{
                System.Console.Write("False");
                return;}
        }
    }
}
