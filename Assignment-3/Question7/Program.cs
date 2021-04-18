using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input distance(meters): ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input time(hour): ");
            double hour = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input time(minutes): ");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input time(seconds): ");
            double sec = Convert.ToDouble(Console.ReadLine());

            double timeSec = (hour*3600) + (min*60) + sec;

            double mps = (distance/timeSec);
            double kph = ((distance/1000) / (timeSec/3600));
            double mph = (kph / 1.609);

            Console.WriteLine("Your speed in meters/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
        }
    }
}
