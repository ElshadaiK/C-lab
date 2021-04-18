using System;

namespace Question120
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new int[]{5,5,1,5,5}));
            Console.WriteLine(helper(new int[]{1,2,3,4}));
            Console.WriteLine(helper(new int[]{3,3,5,5,5,5}));
            Console.WriteLine(helper(new int[]{1,5,5,7,8,10}));
        
            static bool helper(int[] numbers){
                for(int i = 0; i < numbers.Length; i++){
                    if((numbers[i] == 5) && (numbers[i+1] == 5 || numbers[i+2] == 5))
                        return true;
                }
                return false;
            }
        }
    }
}
