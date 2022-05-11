using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSpacific("I am an argument");
            Console.Read();
        }

        public static void WriteSomething()
        {
            Console.WriteLine("i am called from a method");

        }

        public static void WriteSpacific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}

