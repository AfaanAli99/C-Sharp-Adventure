using System;

namespace Challange8
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int num1 = -3; num1 < 4; num1++)
            {
                Console.WriteLine(num1);
            }
            Console.WriteLine("-------------------------------");

            int num2 = 3;
            while (num2 >= -3)
            {
                Console.WriteLine(num2);
                num2--;
            }
        }
    }
}

