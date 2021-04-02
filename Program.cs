using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name!}");

            Randomize();
        }

        static int Sum(){
            Console.WriteLine("Enter a");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            var b = Convert.ToInt32(Console.ReadLine());

            var res = a+b;
            Console.WriteLine(res);
            return res;
        }

        static double Div(){
            Console.WriteLine("Enter a");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b");
            var b = Convert.ToDouble(Console.ReadLine());

            double res = a/b;
            Console.WriteLine(res);
            return res;
        }
        static double Calc(string expression){
            var res = expression.Split();
            Console.WriteLine(res);

            return 0;
        }
    
        static void Swapper(){
            Console.WriteLine("First number?");
            var first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second number?");
            var second = Convert.ToDouble(Console.ReadLine());

            var mult = first * second;
            first = mult / first;
            second = mult / first;
            Console.WriteLine($"First number: {first} Second number: {second}");
        }

        static void Multiplier(){
                Console.WriteLine("First number?");
                var first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Third number?");
                var third = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{first} X {second} X {third} = {first * second * third}");
            }
        
        static void AllOperations(){
                Console.WriteLine("First number?");
                var first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{first} + {second} = {first + second }");
                Console.WriteLine($"{first} - {second} = {first - second }");
                Console.WriteLine($"{first} X {second} = {first * second }");
                Console.WriteLine($"{first} / {second} = {first / second }");
                Console.WriteLine($"{first} mod {second} = {first % second }");
            }
        static void MultTable(){
                Console.WriteLine("Enter number?");
                var num = Convert.ToDouble(Console.ReadLine());
                for(int i = 0; i<11; i++){
                    Console.WriteLine($"{num} X {i} = {num * i }");
                
                }
        }
        static void Average(){
                Console.WriteLine("First number?");
                var first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Third number?");
                var third = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Fourth number?");
                var fourth = Convert.ToDouble(Console.ReadLine());
                
                var result = (first + second + third + fourth)/4;
                Console.WriteLine($"The average of {first} , {second} , {third} , {fourth} is: {result}");
        }
        static void Associative(){
                Console.WriteLine("First number?");
                var first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Third number?");
                var third = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Result of specified numbers {first}, {second}, and {third}, (x+y).z is {(first+second)*third} and x.y + y.z is {(first*second) + (second*third)}");
            }
        static void Randomize(){
                Console.WriteLine("Your age?");
                var age = Convert.ToInt16(Console.ReadLine());
                string[] arr = {"older", "younger"};
                Random randomGenerator = new Random();
                var NextId = randomGenerator.Next(0, 2);


                Console.WriteLine($"You look {arr[NextId]} than {age}");
            }
        
    
    }
}
