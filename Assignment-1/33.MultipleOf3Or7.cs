using System;

namespace HelloWorld{
    class MultipleOf3Or7
    {
        static bool multipleOf3Or7(){
            var res = false;
            Console.WriteLine("Enter the number?");
            var input = Convert.ToInt32(Console.ReadLine());
            if(input%7 == 0 || input%3 == 0){
                res = true;
            }
            return res;
            
        }

    }
}