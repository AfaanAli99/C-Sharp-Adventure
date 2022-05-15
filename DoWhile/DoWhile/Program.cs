using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int lenghtOfText = 0;
            string wholeText = string.Empty;
            do
            {
                Console.WriteLine("Please ener a name");
                string friendName = Console.ReadLine();

                int correctlen = friendName.Length;
                lenghtOfText += correctlen;

                
                wholeText += friendName;
            } while (lenghtOfText < 20);
            Console.WriteLine($"that was enough {wholeText}");
        }
    }
}

