using System;

namespace HelloWorld{
    class Multiplier
    {
        public void multiplier(){
                Console.WriteLine("First number?");
                var first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Third number?");
                var third = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{first} X {second} X {third} = {first * second * third}");
            }
    }
}