using System;

namespace HelloWorld{
    class SumDigit
    {
        static int sumDigit(){
            int res = 0;
            Console.WriteLine("Enter the number?");
            var input = Convert.ToInt32(Console.ReadLine());
            var prc = input.ToString();
            for(int i = 0; i<prc.Length; i++){
                res += (prc[i] - '0');
            }
            return res;
        }

    }
}