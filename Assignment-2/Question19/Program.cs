using System;

namespace Question19
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
                if (num1==num2){
                    System.Console.Write("0");
                }
                else{
                    if(Math.Abs(num1-100)> Math.Abs(num2-100)){
                        System.Console.WriteLine($"{num2}");
                    }
                    else{
                        System.Console.WriteLine($"{num1}");
                    }
                }
        }
    }
}
