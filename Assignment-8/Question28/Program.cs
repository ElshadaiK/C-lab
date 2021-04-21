using System;
using System.Globalization;

namespace Question28
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "sister";
            string str2 = "Sister";
            string relation;
            int result;

            result = String.Compare(str1, str2, new CultureInfo("en-US"), 
                                    CompareOptions.None);
            if (result > 0)
                relation = "comes after";
            else if (result == 0)
                relation = "is the same as";
            else
                relation = "comes before";

            Console.WriteLine("'{0}' {1} '{2}'.", 
                                str1, relation, str2);

            result = String.Compare(str1, str2, new CultureInfo("en-US"), 
                                    CompareOptions.IgnoreCase);
            if (result > 0)
                relation = "comes after";
            else if (result == 0)
                relation = "is the same as";
            else
                relation = "comes before";

            Console.WriteLine("'{0}' {1} '{2}'.", 
                                str1, relation, str2);

            result = String.CompareOrdinal(str1, str2);
            if (result > 0)
                relation = "comes after";
            else if (result == 0)
                relation = "is the same as";
            else
                relation = "comes before";

            Console.WriteLine("'{0}' {1} '{2}'.", 
                                str1, relation, str2);
        }
    }
}
