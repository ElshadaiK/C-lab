using System;

namespace Question124
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helper(new int[] {3,5,5,3,7}));
            Console.WriteLine(helper(new int[] {3,5,5,4,1,5,7}));
            Console.WriteLine(helper(new int[] {3,5,5,5,5,5}));
            Console.WriteLine(helper(new int[] {2,4,5,5,6,7,5}));

            static bool helper(int[] numbers, int nb = 5)
            {
                bool serie = false;

                for (int i = 0, size = numbers.Length; i < size; i++)
                {
                    if(numbers[i] == nb && i > 0 && numbers[i-1] == nb)                                    
                        serie = true;   // start of a serie                
                    else if(serie && i < size - 1 && numbers[i+1] == nb)    
                        serie = false;  // it's a serie but now broken if next i == nb
                }
                return serie;
            }
        }
    }
}
