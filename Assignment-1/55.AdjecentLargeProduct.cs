using System;
using System.Linq;

namespace HelloWorld{
    class AdjecentLargeProduct
    {
        public static int array_adjacent_elements_product(int[] input_array)
            {
            int array_index = 0;
            int product = input_array[array_index] * input_array[array_index + 1];

            array_index++;
            while (array_index + 1 < input_array.Length)
            {
                product = ((input_array[array_index] * input_array[array_index + 1]) > product) ?
                        (input_array[array_index] * input_array[array_index + 1]) :
                            product;
                array_index++;
            }

            return product;        
        }

    }
}