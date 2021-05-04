using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = Int32.MaxValue;
            int int2 = Int32.MaxValue;
            long longResult;
            longResult = Math.BigMul(int1, int2);
            Console.WriteLine("{0} * {1} = {2}", int1, int2, longResult);
        }
    }
}
