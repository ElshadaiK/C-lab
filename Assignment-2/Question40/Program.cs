using System;

namespace Question40
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static int Question40(int number_1, int number_2)
        {
            return number_1 + number_2 >= 10 && number_1 + number_2 <= 20 ? 30 : number_1 + number_2;
        }
    }
}
