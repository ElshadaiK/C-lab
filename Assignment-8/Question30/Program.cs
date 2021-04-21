using System;
using System.Globalization;

namespace Question30
{
    class Program
    {
        static void Main(string[] args)
        {
            string strLow = "xyz";
            string strCap = "XYZ";
            string result = "equal to ";
            int x = 0;
            int pos = 1;

            x = String.CompareOrdinal(strLow, pos, strCap, pos, 1);
            if (x < 0) result = "less than";
            if (x > 0) result = "greater than";
            Console.WriteLine("CompareOrdinal(\"{0}\"[{2}], \"{1}\"[{2}]):", strLow, strCap, pos);
            Console.WriteLine("   '{0}' is {1} '{2}'", strLow[pos], result, strCap[pos]);

            x = String.Compare(strLow, pos, strCap, pos, 1, false, new CultureInfo("en-US"));
            if (x < 0) result = "less than";
            else if (x > 0) result = "greater than";
            Console.WriteLine("Compare(\"{0}\"[{2}], \"{1}\"[{2}]):", strLow, strCap, pos);
            Console.WriteLine("   '{0}' is {1} '{2}'", strLow[pos], result, strCap[pos]);
        }
    }
}
