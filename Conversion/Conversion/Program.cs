using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85";
            string stringForInt = "12345";

            float newFloat = Int32.Parse(stringForFloat);
            int newInt = Int32.Parse(stringForInt);
            Console.WriteLine(newFloat);
            Console.WriteLine(newInt);
        }
    }
}

