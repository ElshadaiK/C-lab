using System;

namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: "); 
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: "); 
            int num2 = Convert.ToInt32(Console.ReadLine());
 
            double hcf = gcd(num1, num2);
            double lcm = (num1 * num2) / hcf;
 
            Console.WriteLine("The GCD of {0} and {1} is {2}", num1, num2, hcf);
            Console.WriteLine("The LCM of {0} and {1} is {2}", num1, num2, lcm);
        }
        static double gcd(long n1, long n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return gcd(n2, n1 % n2);
            }
        }
    }
}
