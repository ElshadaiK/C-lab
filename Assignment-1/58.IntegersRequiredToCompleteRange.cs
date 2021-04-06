using System;
using System.Linq;

namespace HelloWorld{
    class IntegersRequiredToCompleteRange
    {
        public static int consecutive_array(int[] input_Array)
        {
            Array.Sort(input_Array);
            int ctr = 0;
            for(int i = 0; i < input_Array.Length - 1; i++){
            ctr += input_Array[i+1] - input_Array[i] - 1;
            }
            return ctr;
        }
    }
}