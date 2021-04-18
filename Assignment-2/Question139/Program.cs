using System;

namespace Question139
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static bool Question139(int n)
           {
             while (n > 0)
               {
                if (n % 10 == 2) return true;
                n /= 10;
               }
            return false;
        }
    }
}
