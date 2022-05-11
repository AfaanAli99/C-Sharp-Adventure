using System;

namespace Catch2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 0;

            double result;
           
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cant divide by 0");
            }
        }
    }
}

