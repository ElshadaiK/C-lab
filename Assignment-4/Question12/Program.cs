using System;

namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the Roll Number of the student :");
            int rollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the Student :");
            string name = Console.ReadLine();

            Console.Write("Input Physics mark: ");
            double physics = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Chemistry mark: ");
            double chemistry = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Computer Application mark: ");
            double ca = Convert.ToDouble(Console.ReadLine());

            double total = physics + chemistry + ca;
            double percentage = total / 3;

            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name of Student: {name}");
            Console.WriteLine($"Mark in Physics: {physics}");
            Console.WriteLine($"Mark in Chemistry: {chemistry}");
            Console.WriteLine($"Mark in Computer Application: {ca}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Percentage: {percentage}");
        }
    }
}
