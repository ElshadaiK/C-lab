using System;

namespace HelloWorld{
    class FirstChar
    {
        static void firstChar(){
            Console.WriteLine("Enter string?");
            var data = (Console.ReadLine());
            var firstChar = "" + data[0];
            var result = firstChar + data + firstChar;
            Console.WriteLine($"{result}");     
                
        }

    }
}