using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal decimalNumber;
            decimalNumber = 52.7365m;
            Console.WriteLine("Original Decimal Number: "+decimalNumber);
            Console.WriteLine("The whole number and fractional part of the said positive Decimal number:");
            Console.WriteLine(Math.Truncate(decimalNumber));
            Console.WriteLine(decimalNumber-Math.Truncate(decimalNumber));

            decimalNumber = -52.736m;
            Console.WriteLine("Original Decimal Number: "+decimalNumber);
            Console.WriteLine("The whole number and fractional part of the said negative Decimal number:");
            Console.WriteLine(Math.Truncate(decimalNumber)); 
            Console.WriteLine(decimalNumber-Math.Truncate(decimalNumber)); 

            double floatNumber;
            floatNumber = 92.73165;
            Console.WriteLine("Original Double Number: "+floatNumber);
            Console.WriteLine("The whole number and fractional part of the said positive Float number:");
            Console.WriteLine(Math.Truncate(floatNumber));
            Console.WriteLine(floatNumber-Math.Truncate(floatNumber));
            
            floatNumber = -42.7636;
            Console.WriteLine("Original Double Number: "+floatNumber);
            Console.WriteLine("The whole number and fractional part of the said negative Float number:");
            Console.WriteLine(Math.Truncate(floatNumber)); 
            Console.WriteLine(floatNumber-Math.Truncate(floatNumber));
        }
    }
}
