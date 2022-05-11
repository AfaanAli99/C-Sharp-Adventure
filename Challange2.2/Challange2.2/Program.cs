using System;

namespace Challange2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last name: ");
            String lastName = Console.ReadLine();
            string fullName = firstName+" " + lastName;
            Console.WriteLine(fullName);
        }
    }
}

