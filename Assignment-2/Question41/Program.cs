using System;

namespace Question41
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
            if ((num1==5) || (num2==5)){
                System.Console.Write("True");
                return;
            }
            else if (((num1-num2)==5) || ((num2-num1)==5)){
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
