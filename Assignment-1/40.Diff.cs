using System;

namespace HelloWorld{
    class Diff
    {
        static int diff(){
            Console.WriteLine("Enter the first number?");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number?");
            var second = Convert.ToInt32(Console.ReadLine());
            var diff = 0;
            if(Math.Abs(first - 20) > Math.Abs(second - 20)){
                diff = second;
            }
            else{
                if(Math.Abs(second - 20) > Math.Abs(first - 20)){
                    diff = first;
                }
            }
            return diff;
        }

    }
}