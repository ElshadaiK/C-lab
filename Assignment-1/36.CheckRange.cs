using System;

namespace HelloWorld{
    class CheckRange
    {
        static bool checkRange(){
            var res = false;
            Console.WriteLine("Enter the first number?");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number?");
            var second = Convert.ToInt32(Console.ReadLine());
            if((first < 10 && first > -10) || (second < 10 && second > -10)){
                res = true;
            }
            return res;
            
        }

    }
}