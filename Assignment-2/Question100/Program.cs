using System;

namespace Question100
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static bool Question100(int[] numbers)
        {
            return numbers.Length == 2
                && ((numbers[0] == 10 && numbers[1] == 10)
                     || (numbers[0] == 20 && numbers[1] == 20));
        }
    }
}
