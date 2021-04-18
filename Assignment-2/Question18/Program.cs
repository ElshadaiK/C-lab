using System;
using System.Linq;

namespace Question18
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxnum;   
	        int []numbers = new int[3];
            for(int i = 0;i<numbers.Length;i++)
                {
                System.Console.Write("enter num");
                numbers[i]= int.Parse(System.Console.ReadLine());
                }
            maxnum=numbers.Max();
            System.Console.WriteLine($"{maxnum}");
        }
    }
}
