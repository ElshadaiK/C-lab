using System;

namespace HelloWorld{
    class Associative
    {
        public void associative(){
                Console.WriteLine("First number?");
                var first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Third number?");
                var third = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Result of specified numbers {first}, {second}, and {third}, (x+y).z is {(first+second)*third} and x.y + y.z is {(first*second) + (second*third)}");
            }

    }
}