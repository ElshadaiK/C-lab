using System;

namespace Question39
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static bool Question39(int[] numbers)
        {
            int array_length = numbers.Length - 1, n = 0;
            for (int i = 0; i < array_length; i++)
            {
                n = numbers[i];
                if (n == numbers[i + 1] && n == numbers[i + 2]) return true;
            }
            return false;
        }
    }
}
