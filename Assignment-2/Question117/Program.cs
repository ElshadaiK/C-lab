using System;
using System.Linq;

namespace Question117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new int[]{5,5,5,5,5}));
            Console.WriteLine(helper(new int[]{3,3,3,3}));
            Console.WriteLine(helper(new int[]{3,3,3,5,5,5}));
            Console.WriteLine(helper(new int[]{1,6,8,10}));
        
            static bool helper(int[] numbers){
                return numbers.Contains(3) || numbers.Contains(5);
            }
        }
    }
}
