using System;
using System.Linq;

namespace HelloWorld{
    class RangeWithin
    {
        public static bool result(int n) {
        if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
        return true;
        return false;
        }

    }
}