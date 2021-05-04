using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 123456;
            Console.WriteLine("Original Integer value: " + n);
            Console.WriteLine(ReverseDigits(n));
            n = -7654;
            Console.WriteLine("Original Integer value: " + n);
            Console.WriteLine(ReverseDigits(n));	  
            n = 100;
            Console.WriteLine("Original Integer value: " + n);
            Console.WriteLine(ReverseDigits(n));		
        }
        public static int ReverseDigits(int x)
        {
            var result = 0;

            var max_val = int.MaxValue / 10;
            var min_val = int.MinValue / 10;

            for (; x != 0; x /= 10)
            {
                if (result > max_val || result < min_val)
                {
                    return 0;
                }
                result = result * 10 + x % 10;
            }

            return result;
        }
    }
}
