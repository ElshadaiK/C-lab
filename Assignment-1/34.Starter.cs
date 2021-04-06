using System;

namespace HelloWorld{
    class Starter
    {
        static bool starter(string tag){
            var res = false;
            Console.WriteLine("Enter the sentence?");
            var input = (Console.ReadLine()).Split(' ');
            if(input[0] == tag){
                res = true;
            }
            return res;
            
        }

    }
}