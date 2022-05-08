using System;

namespace Challange1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Enter name");
            string userInput = Console.ReadLine();
            name = userInput;
            string upperCase = userInput.ToUpper();
            string lowerCase = userInput.ToLower();
            string trim = userInput.Trim();
            string subString = userInput.Substring(3);
            Console.WriteLine($"your name is {name} \nYour name in upper case {upperCase} \nYour name in lower case {lowerCase} \nName with trim {trim}\nSub string {subString}");
        }
    }
}

