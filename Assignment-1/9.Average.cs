using System;

namespace HelloWorld{
    class Average
    {
        public void average(){
                Console.WriteLine("First number?");
                var first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Third number?");
                var third = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Fourth number?");
                var fourth = Convert.ToDouble(Console.ReadLine());
                
                var result = (first + second + third + fourth)/4;
                Console.WriteLine($"The average of {first} , {second} , {third} , {fourth} is: {result}");
        }

    }
}