using System;

namespace Question131
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] item = helper(new[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            static int[] helper(int[] numbers)
            {
                int size = numbers.Length, index = 0;
                int[] arra1 = new int[size];

                for (int i = 0; i < size; i++)
                {
                    if (numbers[i] != 5)
                    {
                        arra1[index++] = numbers[i];
                    }
                }

                return arra1;
            }
        }
    }
}
