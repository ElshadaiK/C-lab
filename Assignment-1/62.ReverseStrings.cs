using System;
using System.Linq;

namespace HelloWorld{
    class ReverseStrings
    {
        public static string reverse_remove_parentheses(string str)
        {
            int lid = str.LastIndexOf('(');
            if (lid == -1)
            {
                return str;
            }
            else
            {
                int rid = str.IndexOf(')', lid);

                return reverse_remove_parentheses(
                      str.Substring(0, lid)
                    + new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray())
                    + str.Substring(rid + 1)
                );
            }
        }
  

    }
}