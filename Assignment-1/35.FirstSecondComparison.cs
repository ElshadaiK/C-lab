using System;

namespace HelloWorld{
    class FirstSecondComparison
    {
        static bool firstSecondComparison(){
            var res = false;
            Console.WriteLine("Enter the first number? <100");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number? >200");
            var second = Convert.ToInt32(Console.ReadLine());
            if(first < 100 && second > 200){
                res = true;
            }
            return res;
            
        }

    }
}