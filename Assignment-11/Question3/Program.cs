using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many natural numbers do you want to add: ");
            int n = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("The sum of first {0} natural numbers is: {1}", n,SumOfTen(1,n));
        }

        static int SumOfTen(int min, int max) 
        {
            return CalcuSum(min, max);
        }

        static int CalcuSum(int min, int val) 
        {
            if (val == min)
                return val;
            return val + CalcuSum(min, val - 1);
        }
    }
}
