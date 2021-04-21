using System;

namespace Question41
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "Actions speak louder than words", "Hello!", "Python.", 
                           "PHP.", "random" };
            foreach (var value in strings) 
            {
                bool endsInPeriod = value.EndsWith(".");
                Console.WriteLine("'{0}' ends in a period: {1}", 
                                value, endsInPeriod);
            }
        }
    }
}
