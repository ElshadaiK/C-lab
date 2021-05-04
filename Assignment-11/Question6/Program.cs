using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the range to print starting from 1: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Even numbers from 1 to {0} are : ", n);
            EvenAndOdd(2, n);
            
            Console.WriteLine("");
            Console.WriteLine("Odd numbers from 1 to {0} are : ", n);
            EvenAndOdd(1, n);
        }
        static void EvenAndOdd(int stVal, int n)
        {
            if(stVal > n)
                return ;
            Console.Write("{0} ", stVal);
            EvenAndOdd(stVal+2, n);
        }
    }
}
