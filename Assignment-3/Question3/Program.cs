using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int i;
            int count = 0;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the User Id");
                string userid = Console.ReadLine();
                Console.WriteLine("Enter the Password");
                string password = Console.ReadLine();
                count++;
                if (userid == "username" && password == "password" && count != n)
                {
                    Console.WriteLine("The User Authentication successfull");
                    break;
                }
                else if(count == n)
                {
                    Console.WriteLine("The User Authentication failed");
                    break;
                }
            }
        }
    }
}
