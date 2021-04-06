using System;

namespace HelloWorld{
    class Div
    {
        public double div(){
            Console.WriteLine("Enter a");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b");
            var b = Convert.ToDouble(Console.ReadLine());

            double res = a/b;
            Console.WriteLine(res);
            return res;
        }

    }
}