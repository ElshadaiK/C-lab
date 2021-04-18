using System;
using System.Linq;
using System.Collections.Generic;

namespace Question146
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrLastDigit = unit(new List<int> { 10, 22, 35 , 41 });
            foreach(var num in arrLastDigit)
            {
                Console.Write($"{num} ");
            }
        }
        static List<int> unit(List<int> nums)
        {
            IEnumerable<int> digits =  nums.Select(x => x%10);
            return digits.ToList();
        }
    }
}
