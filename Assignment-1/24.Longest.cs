using System;

namespace HelloWorld{
    class Longest
    {
        static string longest(){
            Console.WriteLine("Enter string?");
            var input = (Console.ReadLine());
            var res = input.Split(' ');
            int ind = 0;
            for(int i = 1; i < res.Length; i++){
                if(res[i].Length > res[ind].Length){
                    ind = i;
                }
            }
            
            return res[ind];

            
        }

    }
}