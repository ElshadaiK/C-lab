using System;
using System.Threading;

namespace Question29
{
    class Program
    {
        static void Main(string[] args)
        {
            string intro = "Compare three versions of the letter I using different " + 
                   "values of StringComparison.";

            string[] threeIs = new string[3];
            threeIs[0] = "\u0069";
            threeIs[1] = "\u0131";
            threeIs[2] = "\u0049";

            string[] unicodeNames = 
                    {
                    "LATIN SMALL LETTER I (U+0069)", 
                    "LATIN SMALL LETTER DOTLESS I (U+0131)", 
                    "LATIN CAPITAL LETTER I (U+0049)"
                    };

            StringComparison[] scValues = {
                StringComparison.CurrentCulture,
                StringComparison.CurrentCultureIgnoreCase,
                StringComparison.InvariantCulture,
                StringComparison.InvariantCultureIgnoreCase,
                StringComparison.Ordinal,
                StringComparison.OrdinalIgnoreCase };

            Console.Clear();
            Console.WriteLine(intro);

            Console.WriteLine("The current culture is {0}.\n", 
                            Thread.CurrentThread.CurrentCulture.Name);

            foreach (StringComparison sc in scValues)
            {
                Console.WriteLine("StringComparison.{0}:", sc);

                Test(0, 1, sc, threeIs, unicodeNames);
                Test(0, 2, sc, threeIs, unicodeNames);
                Test(1, 2, sc, threeIs, unicodeNames);

                Console.WriteLine();
            }
            }
            protected static void Test(int x, int y, 
                                    StringComparison comparison, 
                                    string[] testI, string[] testNames)
            {
                string resultFmt = "{0} is {1} {2}";
                string result = "equal to";
                int cmpValue = 0;
            //
                cmpValue = String.Compare(testI[x], testI[y], comparison);
                if      (cmpValue < 0) 
                    result = "less than";
                else if (cmpValue > 0)
                    result = "greater than";
                Console.WriteLine(resultFmt, testNames[x], result, testNames[y]);
        }
    }
}
