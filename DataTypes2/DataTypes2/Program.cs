using System;

namespace DataTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.Write("enter a string");
            int asciiVal = Console.Read();

            Console.WriteLine("You have entered {0}", asciiVal);
            Console.ReadKey();
        }
    }
    
}

