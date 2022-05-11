using System;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string username = "";
            Console.WriteLine("please enter username");
            username = Console.ReadLine();

            if (isRegistered && username != "" && username.Equals("admin"))
            {
                Console.WriteLine("Hi regestered user");
                
                
                    Console.WriteLine($"Hi there, {username}");
                    
                    
                        Console.WriteLine("Hello Admin");
                    
                
            }
        }
    }
}

