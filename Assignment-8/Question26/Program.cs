using System;

namespace Question26
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringUpper = "\x0051\x0052\x0053";
            string stringLower = "\x0071\x0072\x0073";

            Console.WriteLine("Comparing '{0}' and '{1}':", 
                                stringUpper, stringLower);

            Console.WriteLine("The Strings are equal when capitalized? {0}",
                                String.Compare(stringUpper.ToUpper(), stringLower.ToUpper()) == 0 
                                            ? "true" : "false");

            Console.WriteLine("The Strings are equal when case is ignored? {0}",
                                String.Compare(stringUpper, stringLower, true) == 0
                                            ? "true" : "false" );
        }
    }
}
