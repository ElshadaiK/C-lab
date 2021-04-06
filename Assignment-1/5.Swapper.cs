using System;

namespace HelloWorld{
    class AllOperations
    {
        public void allOperations(){
                Console.WriteLine("First number?");
                var first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{first} + {second} = {first + second }");
                Console.WriteLine($"{first} - {second} = {first - second }");
                Console.WriteLine($"{first} X {second} = {first * second }");
                Console.WriteLine($"{first} / {second} = {first / second }");
                Console.WriteLine($"{first} mod {second} = {first % second }");
            }
        

    }
}