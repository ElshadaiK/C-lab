using System;

namespace Question17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Cost Price: ");  
            int cost = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Input Selling Price: ");  
            int selling = Convert.ToInt32(Console.ReadLine());  
            
            if (cost > selling) {
                Console.WriteLine($"Loss of {cost-selling}");
            }
            else if (cost < selling) {
                Console.WriteLine($"Profit of {selling-cost}");
            }
            else {
                Console.WriteLine($"No Profit or Loss");
            }
        }
    }
}
