using System;

namespace parseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85";
            string stringForInt = "12345";

            float newFloat = float.Parse(stringForFloat);
            int newInt = Int32.Parse(stringForInt);
            Console.WriteLine(newInt);
            Console.WriteLine(newFloat);
        }
    }
    
}

