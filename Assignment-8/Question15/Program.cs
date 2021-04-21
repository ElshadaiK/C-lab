using System;

namespace Question15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                char chr = arr[i];
                if (Char.IsUpper(chr)){
                    Console.Write(Char.ToLower(chr));
                }
                else {
                    Console.Write(Char.ToUpper(chr));
                }
            }
        }
    }
}
