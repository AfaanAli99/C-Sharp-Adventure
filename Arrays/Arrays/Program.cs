using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 17;
            grades[3] = 19;
            grades[4] = 3;

            Console.WriteLine($"Grages at index 0 : {grades[0]}");

            //assign value
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);

            Console.WriteLine($"Grages at index 0 : {grades[0]}");
            Console.ReadKey();

            int[] gradesOfMathStudants = { 20, 13, 12, 3, 4, 5 };

            Console.WriteLine($"lenght{gradesOfMathStudants.Length}"); 
        }
    }
}

