using System;

namespace Challange5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter User name forregestration");
            string UserName = Console.ReadLine();
            Console.WriteLine("Please choose a password");
            string UserPassword = Console.ReadLine();
            Console.WriteLine("Registration complete");

            Console.WriteLine("Please enter username to login");
            string LoginUsername = Console.ReadLine();

            if (LoginUsername.Equals(UserName))
            {
                Console.WriteLine($"Hello {UserName}, Please enter your password");
                string LoginPssword = Console.ReadLine();
                if (LoginPssword.Equals(UserPassword))
                {
                    Console.WriteLine("You're logged in");
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }
            else
            {
                Console.WriteLine("Not a valid user name");
            }
        }

    }
}

