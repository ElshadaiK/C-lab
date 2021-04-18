using System;

namespace Question38
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static int Question38(int[] numbers)
        {
            var count = 0;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i].Equals(5) && (numbers[i + 1].Equals(5) || numbers[i + 1].Equals(6))) count++;
            }
            return count;
        }
    }
}
