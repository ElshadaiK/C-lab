using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name!}");

            // string fileName = @"C:\Users\fekadu\Documents\WiFi.txt"; 
            // int[] firstMatrix = {10, 20, 30, 40};
            // int[] secondMatrix = {9, 8, 7, 6};
            // Console.WriteLine(Diff());
            var toAdd = new Sum();
            toAdd.sum();

            var toDiv = new Div();
            toDiv.div();

            // TODO 4

            var toSwap = new Swapper();
            toSwap.swapper();

            var toMultiply = new Multiplier();
            toMultiply.multiplier();
            
            }       
    }
}