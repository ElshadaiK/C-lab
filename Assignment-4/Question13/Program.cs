using System;

namespace Question13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in centigrade: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp < 0) Console.WriteLine("Freezing weather");
            else if (temp >= 0 && temp < 10) Console.WriteLine("Very Cold weather");
            else if (temp >= 10 && temp < 20) Console.WriteLine("Cold weather");
            else if (temp >= 20 && temp < 30) Console.WriteLine("Normal in temp");
            else if (temp >= 30 && temp < 40) Console.WriteLine("Its hot");
            else Console.WriteLine("Its very hot");
        }
    }
}
