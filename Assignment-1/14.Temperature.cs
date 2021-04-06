using System;

namespace HelloWorld{
    class Temperature
    {
        public void temperature(){
                Console.WriteLine("Enter degree in celcius?");
                var degree = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Kelvin = {degree + 273}");
                Console.WriteLine($"Fahrenheit = {(degree *9 /5) + 32}");
        }
    }
}