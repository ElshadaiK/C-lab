using System;

namespace Question34
{
    class Program
    {
        static void Main(string[] args)
        {
            Question34();
        }

        static bool Question34()
        {
            //int[] arr = {1,1,2,3,1};
            int[] arr = {1,1,2,4,1};
            //int[] arr = {1,1,2,1,2,3};

            for(int i = 0; i<arr.Length-2; i++)
            {
                if(arr[i]==1 && arr[i+1]==2  && arr[i+2]==3)
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
