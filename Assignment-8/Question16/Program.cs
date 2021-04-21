using System;

namespace Question16
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "username";
            string password = "password";
            bool state = false;

            while (state != true)
            {
                Console.Write("Input a username: ");
                string nameInput = Console.ReadLine();
                Console.Write("Input a password: ");
                string passInput = Console.ReadLine();
                if (nameInput == username && passInput == password) {
                    state = true;
                    System.Console.WriteLine("Password entered successfully");
                } 
            }
        }
    }
}
