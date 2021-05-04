using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "{0}: The greater of{1,3} and{2,3} is {3}.";

            byte xByte1 = 1, xByte2 = 51;
            short xShort1 = -2, xShort2 = 52;
            int xInt1 = -3, xInt2 = 53;
            long xLong1 = -4, xLong2 = 54;
            float xSingle1 = 5.0f, xSingle2 = 55.0f;
            double xDouble1 = 6.0, xDouble2 = 56.0;
            Decimal xDecimal1 = 7m, xDecimal2 = 57m;

            Console.WriteLine("Display the greater of two values:\n");
            Console.WriteLine(str, "Byte   ", xByte1, xByte2, Math.Max(xByte1, xByte2));
            Console.WriteLine(str, "Int16  ", xShort1, xShort2, Math.Max(xShort1, xShort2));
            Console.WriteLine(str, "Int32  ", xInt1, xInt2, Math.Max(xInt1, xInt2));
            Console.WriteLine(str, "Int64  ", xLong1, xLong2, Math.Max(xLong1, xLong2));
            Console.WriteLine(str, "Single ", xSingle1, xSingle2, Math.Max(xSingle1, xSingle2));
            Console.WriteLine(str, "Double ", xDouble1, xDouble2, Math.Max(xDouble1, xDouble2));
            Console.WriteLine(str, "Decimal", xDecimal1, xDecimal2, Math.Max(xDecimal1, xDecimal2));

            string str1 = "{0}: The lesser of{1,3} and{2,3} is {3}.";

            Console.WriteLine("\nDisplay the lesser of two values:\n");
            Console.WriteLine(str1, "Byte   ", xByte1, xByte2, Math.Min(xByte1, xByte2));
            Console.WriteLine(str1, "Int16  ", xShort1, xShort2, Math.Min(xShort1, xShort2));
            Console.WriteLine(str1, "Int32  ", xInt1, xInt2, Math.Min(xInt1, xInt2));
            Console.WriteLine(str1, "Int64  ", xLong1, xLong2, Math.Min(xLong1, xLong2));
            Console.WriteLine(str1, "Single ", xSingle1, xSingle2, Math.Min(xSingle1, xSingle2));
            Console.WriteLine(str1, "Double ", xDouble1, xDouble2, Math.Min(xDouble1, xDouble2));
            Console.WriteLine(str1, "Decimal", xDecimal1, xDecimal2, Math.Min(xDecimal1, xDecimal2));
        }
    }
}
