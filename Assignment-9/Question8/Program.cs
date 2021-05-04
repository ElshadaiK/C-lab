using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of fibonacci series: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Fibonacci(num);
        }

        static void Fibonacci(int num)
        {   
            int n1=0 , n2=1, n3, i;
            Console.Write(n1+" "+n2+" "); //printing 0 and 1    
            for(i=2;i<num;++i) //loop starts from 2 because 0 and 1 are already printed    
            {    
                n3=n1+n2;    
                Console.Write(n3+" ");    
                n1=n2;    
                n2=n3;    
            }    
        }
    }
}
