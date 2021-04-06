using System;

namespace HelloWorld{
    class PosNeg
    {
        static void posNeg(){
                Console.WriteLine("First number?");
                var first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToDouble(Console.ReadLine());
                bool res;
                if((first < 0 && second > 0) || (first > 0 && second < 0)){
                    res = true;
                }
                else{
                    res = false;
                }
                Console.WriteLine($"{res}");
                
            }

    }
}