using System;

namespace HelloWorld{
    class Lower
    {
        static string lower(){
            Console.WriteLine("First number?");
            var result = (Console.ReadLine());
            
            
            return result.ToLower();

            
        }

    }
}