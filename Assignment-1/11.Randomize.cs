using System;

namespace HelloWorld{
    class Randomize
    {
        public void randomize(){
                Console.WriteLine("Your age?");
                var age = Convert.ToInt16(Console.ReadLine());
                string[] arr = {"older", "younger"};
                Random randomGenerator = new Random();
                var NextId = randomGenerator.Next(0, 2);


                Console.WriteLine($"You look {arr[NextId]} than {age}");
            }


    }
}