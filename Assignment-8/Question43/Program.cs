using System;
using System.Threading;

namespace Question43
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Determine whether a string ends with another string, " +
                   "using\n  different values of StringComparison.";

            StringComparison[] scValues = {
                StringComparison.CurrentCulture,
                StringComparison.CurrentCultureIgnoreCase,
                StringComparison.InvariantCulture,
                StringComparison.InvariantCultureIgnoreCase,
                StringComparison.Ordinal,
                StringComparison.OrdinalIgnoreCase };

            Console.Clear();
            Console.WriteLine(str);

            Console.WriteLine("The current culture is {0}.\n", 
                            Thread.CurrentThread.CurrentCulture.Name);

            foreach (StringComparison sc in scValues)
            {
                Console.WriteLine("StringComparison.{0}:", sc);
                Test("xyzPQR", "PQR", sc);
                Test("xyzPQR", "PQR", sc);
                Console.WriteLine();
            }
        }

        protected static void Test(string x, string y, StringComparison comparison)
        {
            string resultFmt = "\"{0}\" {1} with \"{2}\".";
            string result = "does not end";
            if (x.EndsWith(y, comparison))
                result = "ends";
            Console.WriteLine(resultFmt, x, result, y);
        }
    }
}
