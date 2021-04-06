using System;
using System.Linq;

namespace HelloWorld{
    class SumMatrix
    {
        public static int sum_matrix_elements(int[][] my_matrix)
        {
            int x = 0;
            for (int i = 0; i < my_matrix[0].Length; i++)
                for (int j = 0; j < my_matrix.Length && my_matrix[j][i] > 0; j++)
                    x += my_matrix[j][i];

            return x;
        }

    }
}