using System;

namespace Question134
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 3, 15, 15, 5, 5 };
            if (arr.Length > 1)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] == arr[i - 1] && arr[i] == 15)
                    {
                        Console.Write(true);
                        return;
                    }
                }

                Console.Write(false);
            }
        }
    }
}
