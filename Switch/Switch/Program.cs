using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 24;


            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young");
                    break;
                case 25:
                    Console.WriteLine("Good to go");
                    break;
                default:
                    Console.WriteLine("How old are you");
                    break;
            }


            if (age >= 25)
            {
                Console.WriteLine("Good to go");
            }
            else if (age < 25)
            {
                Console.WriteLine("Too young");
            }

            string username = "Afaan";

            switch (username)
            {
                case "Afaan":
                    Console.WriteLine("Username is Afaan");
                    break;
                case "root":
                    Console.WriteLine("username is Root");
                    break;
                default:
                    Console.WriteLine("Username unknown");
                    break;
            }
        }
    }
}

