using System;

namespace Question121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new int[]{3,5,1,3,7 }));
            Console.WriteLine(helper(new int[]{1,2,3,4}));
            Console.WriteLine(helper(new int[]{3,3,5,5,5,5}));
            Console.WriteLine(helper(new int[]{2,5,5,7,8,10}));
            Console.WriteLine(helper(new int[]{2,3,0,7,8,5}));
            
            static bool helper(int[] numbers){
            int threeIndex = Array.IndexOf(numbers, 3);
            return (threeIndex >= 0) && (Array.IndexOf(numbers[threeIndex..],5) >= 0);
            }
        }
    }
}
