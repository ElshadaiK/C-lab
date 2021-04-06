using System;

namespace HelloWorld{
    class HPSentence
    {
        static string hPSentence(){
            string res = "";
            Console.WriteLine("Enter the sentence");
            var input = (Console.ReadLine());
            if(input.Length >= 1 && input[0] == 'P'){
                res += input[0];
                if(input.Length >= 1 && input[1] == 'H'){
                    res += input[1];
                }
            }
            return res;
            
        }

    }
}