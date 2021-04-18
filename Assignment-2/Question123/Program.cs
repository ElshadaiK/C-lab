using System;
using System.Linq;

namespace Question123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new int[]{3,5,1,5,3,5,7,5,1,5}));
            Console.WriteLine(helper(new int[]{3,5,5,5,5,5,5}));
            Console.WriteLine(helper(new int[]{3,5,2,5,4,5,7,5,8,5}));
            Console.WriteLine(helper(new int[]{2,4,5,5,5,5}));


            static bool helper(int[] numbers)
            {
                if(numbers.Count(item => item == 5) < 5)
                    return false;
                for(int i = 0; i < numbers.Length-1; i++)
                    if(numbers[i] == 5 && numbers[i+1] == 5)
                        return false;                    
                return true;            
            }
        }
    }
}
