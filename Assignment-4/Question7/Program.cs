using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height (in centimeter): ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height < 150) Console.WriteLine("The person is a Dwarf.");
            else if (height >= 150 && height <= 175) {
                Console.WriteLine("The person is average.");
            } else {
                Console.WriteLine("The person is tall.");
            }
        }
    }
}
