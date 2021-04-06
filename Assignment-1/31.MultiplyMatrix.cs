using System;

namespace HelloWorld{
    class MultiplyMatrix
    {
        public Array multiplyMatrix(int[] first, int[] second){
            int minVal = Math.Min(first.Length, second.Length);
            int[] res = new int[minVal];
            for (int i = 0; i < minVal; i++) {
                res[i] = first[i] * second[i];
            }
            Console.WriteLine(string.Join(", ", res));
            return res;
            
        }

    }
}