using System;

namespace HelloWorld{
    class IndexingStrings
    {
        public void indexingStrings(){
                Console.WriteLine("Enter string?");
                var data = (Console.ReadLine());
                
                Random randomGenerator = new Random();
                for(int j = 0; j<3; j++){
                    var NextId = randomGenerator.Next(0, data.Length);
                    Console.WriteLine($"{data.Remove(NextId, 1)}");
                
                }

        }
    }
}