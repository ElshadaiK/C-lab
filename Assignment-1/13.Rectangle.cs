using System;

namespace HelloWorld{
    class Rectangle
    {
        public  void rectangle(){
                Console.WriteLine("Enter number?");
                var num = Convert.ToDouble(Console.ReadLine());
                for(int i = 0; i<5; i++){
                    if(i== 0 || i==4){
                        for(int j = 0; j<3; j++){
                            Console.Write($"{num}");
                        }
                        Console.WriteLine();
                    }
                    else{
                        for(int j = 0; j<2; j++){
                            Console.Write($"{num} ");
                        }
                        Console.WriteLine();
                    }
                
                }
        }
    }
}