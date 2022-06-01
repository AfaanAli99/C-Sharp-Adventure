using System;

namespace Challange9
{
    class Program
    {

        static void Main(string[] args)
        {
            string userInputMarks = "0";
            int totalMarks = 0;
            int currentNumber = 0;
            int whileCounter = 0;
            while (userInputMarks != "1")
            {
                Console.WriteLine($"Last number was {currentNumber}");
                Console.WriteLine("Enter next number");
                Console.WriteLine($"Total entries {whileCounter}");

                userInputMarks = Console.ReadLine();
                if (userInputMarks != "-1")
                {
                    double average = (double)totalMarks / (double)whileCounter;
                    Console.WriteLine($"The average is {average}");
                }
                if (int.TryParse(userInputMarks, out currentNumber) && currentNumber > 0 && currentNumber <= 20)
                {
                    totalMarks = totalMarks + currentNumber;
                }
                else if (!(userInputMarks == "-1"))
                {
                    Console.WriteLine("Please enter a valid number between 0 and 20");
                    continue;
                }


                whileCounter++;
            }

        }

        static void Average()
        {

        }
    }
}

