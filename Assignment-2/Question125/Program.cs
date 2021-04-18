using System;

namespace Question125
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new int[]{3,7,5,5,3,7},2));
            Console.WriteLine(helper(new int[]{3,7,5,5,3,7},3));
            Console.WriteLine(helper(new int[]{3,7,5,5,3,7,5},3));              
            
            static bool helper(int[] numbers, int nElement){
            int[] a = numbers[0..(nElement)],
                  b = numbers[^(nElement)..];
            
            for(int i = 0; i < a.Length; i++)
                if(a[i] != b[i]) return false;
            
            return true;
            }
        }
    }
}
