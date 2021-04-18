using System;

namespace Question93
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Question93());
        }
        static string Question93()
        {
            int[] arr = { 10, 20, -30, -40, 50 };
            string result = String.Empty;
            for(int i = arr.Length-1; i>=0; i--)
            {
                result += arr[i].ToString() + " ";
            }
            Console.WriteLine(result);
            return result;            
        }
    }
}
