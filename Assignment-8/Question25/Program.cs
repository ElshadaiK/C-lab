using System;
using System.Globalization;
using System.Threading;

namespace Question25
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] cultureNames = { "en-AU", "sv-SE" };
            String[] strs1 = { "case",  "encyclopedia",  
                                    "encyclopedia", "Archeology" };
            String[] strs2 = { "Case", "encyclopedia", 
                                    "encyclopedia" , "ARCHEOLOGY" };
            StringComparison[] comparisons = (StringComparison[]) Enum.GetValues(typeof(StringComparison));

            foreach (var cultureName in cultureNames) 
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
                Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
                for (int ctr = 0; ctr <= strs1.GetUpperBound(0); ctr++) {
                    foreach (var comparison in comparisons) 
                    Console.WriteLine("   {0} = {1} ({2}): {3}", strs1[ctr],
                                        strs2[ctr], comparison, 
                                        String.Equals(strs1[ctr], strs2[ctr], comparison));

                    Console.WriteLine();         
                }
            }
        }
    }
}
