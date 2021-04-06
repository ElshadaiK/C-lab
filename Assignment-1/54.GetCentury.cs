using System;
using System.Linq;

namespace HelloWorld{
    class GetCentury
    {
        public static int getrCentury(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }

    }
}