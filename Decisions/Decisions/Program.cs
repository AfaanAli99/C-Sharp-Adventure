using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter current temprature");
            string userInput = Console.ReadLine();
            int temprature;
            bool success = int.TryParse(userInput, out temprature);

            if (success)
            {
                Console.WriteLine($"Parsing successful. The number is {temprature}");
            }
            else
            {
                Console.WriteLine("Parsing failed");
            }
           
        }
    }
}

