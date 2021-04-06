using System;

namespace HelloWorld{
    class Absolute
    {
        public double absolute(){
                Console.WriteLine("First number?");
                var first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToInt32(Console.ReadLine());
                var result = second - first;

                if(first > second){
                    result = (first - second) * 2;
                }
                
                Console.WriteLine($"Result: {result}");
                return result;

                
            }

    }
}