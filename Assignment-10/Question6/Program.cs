using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple < string, double > [] areas = {
                Tuple.Create("Sitka, Alaska", 2870.3),
                Tuple.Create("New York City", 302.6),
                Tuple.Create("Los Angeles", 468.7),
                Tuple.Create("Detroit", 138.8),
                Tuple.Create("Chicago", 227.1),
                Tuple.Create("San Diego", 325.2)
            };

            Console.WriteLine("{0,-18} {1,14:N1} {2,30}\n", "City", "Area (mi.)",
                "Equivalent to a square with:");

            foreach(var area in areas)
                Console.WriteLine("{0,-18} {1,14:N1} {2,14:N2} miles per side",
                    area.Item1, area.Item2, Math.Round(Math.Sqrt(area.Item2), 2));
        }
    }
}
