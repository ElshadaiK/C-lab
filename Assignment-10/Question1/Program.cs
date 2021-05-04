using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] decimals = {
                Decimal.MaxValue,
                15.55M,
                0M,
                -17.23M,
                Decimal.MinValue
            };
            Console.WriteLine("Absolute value of a number of Decimal values:");
            foreach(decimal value in decimals)
            Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
            double[] doubles = {
                Double.MaxValue,
                15.354e-17,
                14.098123,
                0,
                -17.069713,
                -14.058e18,
                Double.MinValue
            };
            Console.WriteLine("Absolute value of a number of Double values:");
            foreach(double value in doubles)
            Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
            short[] values1 = {
                Int16.MaxValue,
                10328,
                0,
                -1476,
                Int16.MinValue
            };
            Console.WriteLine("Absolute value of a number of Int16 values:");
            foreach(short value in values1) {
                try {
                Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
                } catch (OverflowException) {
                Console.WriteLine("Unable to calculate the absolute value of {0}.",
                    value);
                }
            }
            Console.WriteLine("Absolute value of a number of Int32 values:");
            int[] values2 = {
                Int32.MaxValue,
                16921,
                0,
                -804128,
                Int32.MinValue
            };
            foreach(int value in values2) {
                try {
                Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
                } catch (OverflowException) {
                Console.WriteLine("Unable to calculate the absolute value of {0}.",
                    value);
                }
            }

            long[] values3 = {
                Int64.MaxValue,
                109013,
                0,
                -6871982,
                Int64.MinValue
            };
            Console.WriteLine("Absolute value of a number of Int64 values:");
            foreach(long value in values3) {
                try {
                Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
                } catch (OverflowException) {
                Console.WriteLine("Unable to calculate the absolute value of {0}.",
                    value);
                }
            }
        }
        
    }
}
