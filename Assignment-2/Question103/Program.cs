using System;

namespace Question103
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] item = arr(new[] { 1, 5, 7, 9, 11, 13 }); 
            Console.Write("New array: ");         
            foreach(var i in item)
            {
                Console.Write(i.ToString()+" ");
            }

            static int[] arr(int[] numbers)
            {
            return new int[] { numbers[numbers.Length / 2 - 1], numbers[numbers.Length / 2] };
            }
        }
    }
}
