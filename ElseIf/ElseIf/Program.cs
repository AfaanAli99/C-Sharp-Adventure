using System;

namespace ElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int temprature;
            string userInput = Console.ReadLine();
            int userTemp;
            if (int.TryParse(userInput, out userTemp))
            {
                temprature = userTemp;
            }
            else
            {
                temprature = 0;
                Console.WriteLine($"You Entered {userInput} please enter correct value");
            }

            if (temprature < 10)
            {
                Console.WriteLine("take the coat");
            }

            else if (temprature == 10)
            {
                Console.WriteLine("its 10 degree C");
            }
            else
            {
                Console.WriteLine("warm");
            }
            Console.Read();
        }
    }
}

