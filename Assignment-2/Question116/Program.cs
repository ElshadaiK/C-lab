using System;

namespace Question116
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new[] { 1, 5, 6, 9, 3, 3 }));
            Console.WriteLine(helper(new[] { 1, 5, 5, 5, 10, 17 }));
            Console.WriteLine(helper(new[] { 1, 3, 3, 5, 5, 5}));


             static bool helper(int[] nums) {
                int total3 = 0, total5 =0;

                foreach(int element in nums) {
                    if(element ==5) {
                        total5+=1;
                    }
                    if(element ==3) {
                        total3+=1;
                    }
                }
                return total3> total5;
            }
        }
    }
}
