using System;

namespace Question33
{
    class Program
    {
        static void Main(string[] args)
        {
            Question33();
        }
        static bool Question33()
        {
            //int[] arr = {1,2,9,3};
            int[] arr = {1,2,4,5,6,3};
            //int[] arr = {1,2,2,3};

            int key = 3;
            //int key = 2;
            //int key = 9;
            for(int i = 0; i<5; i++)
            {
                if(arr[i] == key)
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
