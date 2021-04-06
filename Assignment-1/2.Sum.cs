using System;

namespace HelloWorld{
    class Sum
    {
        public int sum(){

        Console.WriteLine("Enter a");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter b");
        var b = Convert.ToInt32(Console.ReadLine());

        var res = a+b;
        Console.WriteLine(res);
        return res;

        }
    }
}