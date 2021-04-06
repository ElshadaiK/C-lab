using System;

namespace HelloWorld{
    class Printer
    {
        public void printer(){
                Console.WriteLine("Enter number?");
                var num = Convert.ToDouble(Console.ReadLine());
                for(int i = 0; i<4; i++){
                    if(i%2 == 1){
                        for(int j = 0; j<4; j++){
                            Console.Write($"{num}");
                        }
                        Console.WriteLine();
                    }
                    else{
                        for(int j = 0; j<4; j++){
                            Console.Write($"{num} ");
                        }
                        Console.WriteLine();
                    }
                
                }
        }
        

    }
}