using System;

namespace Challange5
{
    class Program

    {
        static string userName;
        static string Password;

        static void Main(string[] args)
        {
            Registration();
            LogIn();
        }

        public static void Registration()
        {
            Console.WriteLine("Create a User name");
            userName = Console.ReadLine();
            Console.WriteLine("Create a Password");
            Password = Console.ReadLine();
            Console.WriteLine("Confirm Password");
            if (Password == Console.ReadLine())
            {
                Console.WriteLine($"Registration complete, Hello{userName}");
                Console.WriteLine("--------------------------------------------");
            }
            else
            {
                Console.WriteLine("Password did not match, restart program");
            }
            
        }
        public static void LogIn()
        {
            Console.WriteLine("Enter your username");
            if (userName == Console.ReadLine())
            {
                Console.WriteLine($"Hello {userName}, Please enter  your password");
                if (Password == Console.ReadLine())
                {
                    Console.WriteLine("Logged In");
                    Console.WriteLine("--------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Incorrect Password, restart program");
                }
            }
            else
            {
                Console.WriteLine("User not found, restart program");
            }
        }
    }
}

