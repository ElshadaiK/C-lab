using System;

namespace HelloWorld{
    class TripleSum
    {
        static double tripleSum(){
                Console.WriteLine("First number?");
                var first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToInt32(Console.ReadLine());
                var result = 0;

                if(first == second){
                    result = (first)*6;
                    Console.WriteLine($"They're equal!!! {result}");
                }

                return result;

                
            }

    }
}