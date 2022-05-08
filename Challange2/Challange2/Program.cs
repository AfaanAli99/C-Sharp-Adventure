using System;

namespace Challange2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Enter a charecter to search: ");
            char searchString = Console.ReadLine()[0];
            Console.WriteLine(userInput.IndexOf(searchString));
        }
    }
}

