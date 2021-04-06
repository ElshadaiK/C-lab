using System;
using System.Linq;

namespace HelloWorld{
    class AdjecentLargeProductInteger
    {
        public static int adjacent_Elements_Product(int[] input_Array)
        {
          int max = input_Array[0] * input_Array[1];
           for (int x = 1; x <= input_Array.Length - 2; x++)
           {
              max = Math.Max(max, input_Array[x] * input_Array[x + 1]);
            }
         return max;
      }

    }
}