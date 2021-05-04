using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] values = {
                10.23m,
                10.27m,
                14.34m,
                11.15m,
                41.51m,
                10.65m
            };
            decimal sum = 0;
            foreach(var value in values)
            sum += value;
            Console.WriteLine("True Mean: {0:N2}", sum / values.Length);

            sum = 0;
            foreach(var value in values)
            sum += Math.Round(value, 1, MidpointRounding.AwayFromZero);
            Console.WriteLine("Away From Zero: {0:N2}", sum / values.Length);

            sum = 0;
            foreach(var value in values)
            sum += Math.Round(value, 1, MidpointRounding.ToEven);
            Console.WriteLine("Rounding to Nearest: {0:N2}", sum / values.Length);
        }
    }
}
