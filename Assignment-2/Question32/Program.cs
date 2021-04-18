using System;

namespace Question32
{
    class Program
    {
        static bool Main(string[] args)
        {
            //int[] arr = {1,2,9,3};
            int[] arr = {1,2,2,3};

            //int key = 3;
            //int key = 2;
            int key = 9;
            foreach(int num in arr)
            {
                if(num == key)
                {
                    Console.WriteLine(true);
                    return true;
                }
            }
            Console.WriteLine(false);
            return false;
        }
    }
}
