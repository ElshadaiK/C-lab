using System;
using System.Collections;

namespace Question35
{
    class Program
    {
        static void Main(string[] args)
        {
            const int WORD_SIZE = 4;

            string[] words = { "abcd", "efgh", "ijkl", "mnop" };
            double[] keys = new double[WORD_SIZE];
            string[] letters = new string[WORD_SIZE];
            Random rnd = new Random();

            foreach (string word in words)
            {
                for (int ctr = 0; ctr < word.Length; ctr++)
                {
                    keys[ctr] = rnd.NextDouble();
                    letters[ctr] = word[ctr].ToString();
                }   
                Array.Sort(keys, letters, 0, WORD_SIZE, Comparer.Default);      
                string scrambledWord = String.Concat(letters[0], letters[1], 
                                                    letters[2], letters[3]);
                Console.WriteLine("{0} --> {1}", word, scrambledWord);
            }
        }
    }
}
