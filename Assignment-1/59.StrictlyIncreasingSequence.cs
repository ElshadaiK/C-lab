using System;
using System.Linq;

namespace HelloWorld{
    class StrictlyIncreasingSequence
    {
        public static bool test_Increasing_Sequence(int[] int_seq)
        {
            int x = 0;
            for (int i = 0; i < int_seq.Length - 1; i++)
            {
                if (int_seq[i] >= int_seq[i + 1])
                    x++;
                if (i + 2 < int_seq.Length && int_seq[i] >= int_seq[i + 2])
                    x++;
            }
            return x <= 2;
        }

    }
}