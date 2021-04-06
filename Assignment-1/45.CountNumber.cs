using System;
using System.Linq;

namespace HelloWorld{
    class CountNumber
    {
        public void countNumber(){
            Console.WriteLine("\nInput an integer:");  
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
            Console.WriteLine("Number of " + x + " present in the said array:");
            Console.WriteLine(nums.Count(n => n == x));
        }

    }
}