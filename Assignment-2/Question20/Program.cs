using System;

namespace Question20
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
            if ((40<=num1 && num1<=50)||(40<=num2 && num2<=50)){
                System.Console.Write("True");
                return;
            }
            else if((50<num1 && num1<=60)||(50<num2 && num2<=60)){
                System.Console.Write("True");
                return;
            }
            else{
                System.Console.Write("False");
                return;
            }
        }
    }
}
