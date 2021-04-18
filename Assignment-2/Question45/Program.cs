using System;

namespace Question45
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int sum;
            System.Console.Write("enter number: ");
            num1=int.Parse(System.Console.ReadLine());
            int num2;
            System.Console.Write("enter second number: ");
            num2=int.Parse(System.Console.ReadLine());
            if ((10<=num1 && num1<=20) || (10<=num1 && num1<=20)){
                System.Console.Write("18");
            }
            else{
                sum=num1 + num2;
                System.Console.Write($"The sum is: {sum}");
            }
        }
    }
}
