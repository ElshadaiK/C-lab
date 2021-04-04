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

            string fileName = @"C:\Users\fekadu\Documents\WiFi.txt"; 
            FileSize(fileName);
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
        static void Printer(){
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
        
        static void Rectangle(){
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
        static void Temperature(){
                Console.WriteLine("Enter degree in celcius?");
                var degree = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Kelvin = {degree + 273}");
                Console.WriteLine($"Fahrenheit = {(degree *9 /5) + 32}");
        }

        static void IndexingStrings(){
                Console.WriteLine("Enter string?");
                var data = (Console.ReadLine());
                
                Random randomGenerator = new Random();
                for(int j = 0; j<3; j++){
                    var NextId = randomGenerator.Next(0, data.Length);
                    Console.WriteLine($"{data.Remove(NextId, 1)}");
                
                }

        }
        static void Exchange(){
            Console.WriteLine("Enter string?");
            var data = (Console.ReadLine());
            var result = "" + data[data.Length - 1];
            for(int i = 1; i<data.Length - 1; i++){
                result = result.ToString() + data[i];
            }
            result += data[0];
            Console.WriteLine($"{result}");     
                
        }
        static void FirstChar(){
            Console.WriteLine("Enter string?");
            var data = (Console.ReadLine());
            var firstChar = "" + data[0];
            var result = firstChar + data + firstChar;
            Console.WriteLine($"{result}");     
                
        }
        static void PosNeg(){
                Console.WriteLine("First number?");
                var first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToDouble(Console.ReadLine());
                bool res;
                if((first < 0 && second > 0) || (first > 0 && second < 0)){
                    res = true;
                }
                else{
                    res = false;
                }
                Console.WriteLine($"{res}");
                
            }
        
        static double TripleSum(){
                Console.WriteLine("First number?");
                var first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToInt32(Console.ReadLine());
                var result = 0;

                if(first == second){
                    result = (first)*6;
                    Console.WriteLine($"They're equal!!! {result}");
                }

                return result;

                
            }
        static double Absolute(){
                Console.WriteLine("First number?");
                var first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToInt32(Console.ReadLine());
                var result = second - first;

                if(first > second){
                    result = (first - second) * 2;
                }
                
                Console.WriteLine($"Result: {result}");
                return result;

                
            }
        
        static bool Check20(){
                Console.WriteLine("First number?");
                var first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number?");
                var second = Convert.ToInt32(Console.ReadLine());
                var result = false;

                if((first != second && (first == 20 || second == 20)) || first + second == 20){
                    result = true;
                }
                
                Console.WriteLine($"Result: {result}");
                return result;

                
            }
        static string Lower(){
            Console.WriteLine("First number?");
            var result = (Console.ReadLine());
            
            
            return result.ToLower();

            
        }
        static string Longest(){
            Console.WriteLine("Enter string?");
            var input = (Console.ReadLine());
            var res = input.Split(' ');
            int ind = 0;
            for(int i = 1; i < res.Length; i++){
                if(res[i].Length > res[ind].Length){
                    ind = i;
                }
            }
            
            return res[ind];

            
        }
        
        static void Odd(){
            for(int i = 1; i < 100; i++){
                Console.WriteLine(i);
                i++;
            }
        }
        
        static void Prime(){
            int sum = 2;
            int count = 1;
            for(int i = 2; count < 500; i++){
                int div = 0;
                for(int j = 2; j <= i/2 +1; j++){
                    if(i % j == 0){
                        ++div;
                    }
                    if(div > 2){
                        break;
                    }
                }
                
                if(div == 0){
                    sum += i;
                    count++;

                }
            }
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    
        static int SumDigit(){
            int res = 0;
            Console.WriteLine("Enter the number?");
            var input = Convert.ToInt32(Console.ReadLine());
            var prc = input.ToString();
            for(int i = 0; i<prc.Length; i++){
                res += (prc[i] - '0');
            }
            return res;
        }
        static void ReverseSentence(){
            Console.WriteLine("Enter the sentence?");
            var input = (Console.ReadLine());
            var res = "";
            var prc = input.Split(' ');
            for(int i = prc.Length -1; i>0; i--){
                res += prc[i] + " ";
            }
            res += prc[0];
            Console.WriteLine(res);
        }

        static void FileSize(string fileName){
            System.IO.FileInfo fi = new System.IO.FileInfo(fileName);  
            long size = fi.Length;  
            Console.WriteLine("File Size in Bytes: {0}", size);  
        }
    
    }
}
