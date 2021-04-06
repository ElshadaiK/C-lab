using System;

namespace HelloWorld{
    class MaxMin
    {
        static void maxMin(){
            Console.WriteLine("Enter the first number?");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number?");
            var second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number?");
            var third = Convert.ToInt32(Console.ReadLine());
            var max = first;
            var min = first;
            if(second > max){
                min = max;
                max = second;
            }
            if(third > max){
                max = third;
            }
            if(third < min){
                min = third;
            }
            Console.WriteLine($"Max {max}, Min {min}");
            
        }

    }
}