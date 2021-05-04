using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            str1 = "123456";
            Console.WriteLine("Original String value: " + str1);
            Console.WriteLine(StringToInteger(str1));
            str1 = "+3456";
            Console.WriteLine("Original String value: " + str1);
            Console.WriteLine(StringToInteger(str1));
            str1 = "-123456";
            Console.WriteLine("Original String value: " + str1);
            Console.WriteLine(StringToInteger(str1));
            str1 = "a1234";
            Console.WriteLine("Original String value: " + str1);
            Console.WriteLine(StringToInteger(str1));
            str1 = "123a456";
            Console.WriteLine("Original String value: " + str1);
            Console.WriteLine(StringToInteger(str1));
        }
        public static int StringToInteger(string str1)
        {
            if (string.IsNullOrWhiteSpace(str1)) { return 0; }

            var flag = false;
            var index_num = 0;

            while (index_num < str1.Length && str1[index_num] == ' ') { index_num++; }

            if (str1[index_num] == '-')
            {
                flag = true;
                index_num++;
            }
            else if (str1[index_num] == '+')
            {
                index_num++;
            }
            var max1 = int.MaxValue / 10;
            var max2 = int.MaxValue % 10;
            var result = 0;
            for (; index_num < str1.Length; index_num++)
            {
                var str_digit = str1[index_num] - '0';
                if (str_digit < 0 || str_digit > 9) { break; }

                if (result > max1 ||
                    (result == max1 && str_digit > max2))
                {
                    return flag ? int.MinValue : int.MaxValue;
                }

                result = result * 10 + str_digit;
            }

            return flag ? -result : result;
        }
    }
}
