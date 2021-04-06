using System;

namespace HelloWorld{
    class ContainsHP
    {
        public string containsHP(){
            Console.WriteLine("Enter the sentence");
            var input = (Console.ReadLine());
            if(input.Length >= 2 && input[1] == 'H'){
                if(input.Length >= 3 && input[2] == 'P'){
                    input = input.Remove(1, 2);
                }
            }
            return input;
            
        }

    }
}