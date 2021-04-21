using System;

namespace Question39
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "JAVA";
            string s2 = "Python";

            Console.WriteLine("s1 = '{0}'", s1);
            Console.WriteLine("s2 = '{0}'", s2);

            Console.WriteLine("\nAfter String.Copy...");
            Console.WriteLine("s1 = '{0}'", s1);
            Console.WriteLine("s2 = '{0}'", s2);
            Console.WriteLine("ReferenceEquals: {0}", Object.ReferenceEquals(s1, s2));
            Console.WriteLine("Equals: {0}", Object.Equals(s1, s2));

            Console.WriteLine("\nAfter Assignment...");
            s2 = s1;
            Console.WriteLine("s1 = '{0}'", s1);
            Console.WriteLine("s2 = '{0}'", s2);
            Console.WriteLine("ReferenceEquals: {0}", Object.ReferenceEquals(s1, s2));
            Console.WriteLine("Equals: {0}", Object.Equals(s1, s2));
        }
    }
}
