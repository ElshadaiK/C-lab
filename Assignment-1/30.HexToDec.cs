using System;

namespace HelloWorld{
    class HexToDec
    {
        public void hexToDec(string hexVal){
            int res =  Convert.ToInt32(hexVal, 16);
            Console.WriteLine("Decimal value: {0}", res);  
        }


    }
}