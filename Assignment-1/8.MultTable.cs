using System;

namespace HelloWorld{
    class MultTable
    {
        public void multTable(){
                Console.WriteLine("Enter number?");
                var num = Convert.ToDouble(Console.ReadLine());
                for(int i = 0; i<11; i++){
                    Console.WriteLine($"{num} X {i} = {num * i }");
                
                }
        }

    }
}