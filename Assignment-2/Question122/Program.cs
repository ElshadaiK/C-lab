using System;

namespace Question122
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new int[]{3,5,1,3,7}));
            Console.WriteLine(helper(new int[]{1,2,3,4}));
            Console.WriteLine(helper(new int[]{3,3,5,5,5,5}));
            Console.WriteLine(helper(new int[]{2,4,5,6}));

            static bool helper(int[] numbers)
            {
                for(int i = 0; i < numbers.Length -1; i++)            
                    if((numbers[i] % 2 == 0  && numbers[i+1] % 2 == 0) ||
                    (numbers[i] % 2 != 0  && numbers[i+1] % 2 != 0))
                        return true;            
                return false;
            }
        }
    }
}
