using System;

namespace Question21
{
    class Program
    {
        static void Main(string[] args)
        {   
            helper(5, 7);
            static int helper(int x, int y)
            {
                if (x >= 20 && x <= 30 && y >= 20 && y <= 30)
                {
                    if (x >= y)
                    {
                        return x;
                    }
                    else
                    {
                        return y;
                    }
                }
                else if (x >= 20 && y <= 30)
                {
                    return x;
                }
                else if (y >= 20 && y <= 30)
                {
                    return y;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
