using System;
using System.Linq;

namespace HelloWorld{
    class MiddleElementNewArray
    {
        public void middleElementNewArray(){
            int[] array1 = {1, 2, 5};
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array1));
            int[] array2 = {0, 3, 8};
            Console.WriteLine("\nArray2: [{0}]", string.Join(", ", array2));
            int[] array3 = {-1, 0, 2};
            Console.WriteLine("\nArray3: [{0}]", string.Join(", ", array3));
            int[] new_array = { array1[1], array2[1], array3[1] };
            Console.WriteLine("\nNew array: [{0}]", string.Join(", ", new_array));
        }

    }
}