using System;

namespace Question101
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums= helper(new[] { 1, 5, 7 }); 
            Console.Write("New array: ");         
            foreach(var i in nums)
            {
                Console.Write(i.ToString()+" ");
            }
            
            static int[] helper(int[] numbers)
            {
            for (var i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i].Equals(5) && numbers[i + 1].Equals(7))
                        numbers[i + 1] = 1;
                }
                return numbers;
            }
        }
    }
}
