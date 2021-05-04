using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "{0}: {1,3} is {2} zero.";
            string nl = Environment.NewLine;
            byte xByte1 = 0;
            short xShort1 = -2;
            int xInt1 = -3;
            long xLong1 = -4;
            float xSingle1 = 2.10f;
            double xDouble1 = 6.0;
            Decimal xDecimal1 = -7m;
            Console.WriteLine($"{nl}Test the sign of the following types of values:");
            Console.WriteLine(str, "Byte", xByte1, Helper(Math.Sign(xByte1)));
            Console.WriteLine(str, "Int16", xShort1, Helper(Math.Sign(xShort1)));
            Console.WriteLine(str, "Int32", xInt1, Helper(Math.Sign(xInt1)));
            Console.WriteLine(str, "Int64", xLong1, Helper(Math.Sign(xLong1)));
            Console.WriteLine(str, "Single", xSingle1, Helper(Math.Sign(xSingle1)));
            Console.WriteLine(str, "Double", xDouble1, Helper(Math.Sign(xDouble1)));
            Console.WriteLine(str, "Decimal", xDecimal1, Helper(Math.Sign(xDecimal1)));
        }
        public static string Helper(int compare) 
        {
            if (compare == 0)
                return "equal to";
            else if (compare < 0)
                return "less than";
            else
                return "greater than";
        }
    }
}
