using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Python";
            Console.WriteLine(word.Remove(1, 1));
            Console.WriteLine(word.Remove(0, 1));
            Console.WriteLine(word.Remove(4, 1));
        }
    }
}
