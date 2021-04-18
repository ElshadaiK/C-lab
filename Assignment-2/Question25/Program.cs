using System;

namespace Question25
{
    class Program
    {
        static void Main(string[] args)
        {
            Question25("Python", 2);
            static string Question25(string s, int n)
            {
                string result = String.Empty;
                for (int i = 0; i < n; i++)
                {
                    result += s;
                }
                return result;
            }
        }
    }
}
