using System;

namespace HelloWorld{
    class Exchange
    {
        public void exchange(){
            Console.WriteLine("Enter string?");
            var data = (Console.ReadLine());
            var result = "" + data[data.Length - 1];
            for(int i = 1; i<data.Length - 1; i++){
                result = result.ToString() + data[i];
            }
            result += data[0];
            Console.WriteLine($"{result}");     
                
        }

    }
}