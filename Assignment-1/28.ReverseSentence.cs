using System;

namespace HelloWorld{
    class ReverseSentence
    {
        static void reverseSentence(){
            Console.WriteLine("Enter the sentence?");
            var input = (Console.ReadLine());
            var res = "";
            var prc = input.Split(' ');
            for(int i = prc.Length -1; i>0; i--){
                res += prc[i] + " ";
            }
            res += prc[0];
            Console.WriteLine(res);
        }

    }
}