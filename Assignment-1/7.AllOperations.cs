using System;

namespace HelloWorld{
    class Swapper
    {
        public void swapper(){
            Console.WriteLine("First number?");
            var first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second number?");
            var second = Convert.ToDouble(Console.ReadLine());

            var mult = first * second;
            first = mult / first;
            second = mult / first;
            Console.WriteLine($"First number: {first} Second number: {second}");
        }

    }
}