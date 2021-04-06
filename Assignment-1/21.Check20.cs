using System;

namespace HelloWorld{
    class Check20
    {
        static bool check20(){
                Console.WriteLine("First number?");
                var first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToInt32(Console.ReadLine());
                var result = false;

                if((first != second && (first == 20 || second == 20)) || first + second == 20){
                    result = true;
                }
                
                Console.WriteLine($"Result: {result}");
                return result;

                
            }

    }
}