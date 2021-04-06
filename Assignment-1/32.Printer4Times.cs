using System;

namespace HelloWorld{
    class Printer4Times
    {
        static string printer4Times(){
            var res = "";
            Console.WriteLine("Enter the sentence?");
            var input = (Console.ReadLine());
            var prc = input.Split(" ");
            if(prc.Length < 4){
                res = input;
            }
            else{
                for(int i = 0; i<4; i++){
                    res += prc[prc.Length - 1];
                }
            }
            return res;
            
        }

    }
}