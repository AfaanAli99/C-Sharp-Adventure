using System;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
           int result = Add(15, 31);
           int result2= Mult(2, 5);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(Div(25,13));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Mult(int num3, int num2)
        {
            return num3 * num2;
        }

        public static double Div(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}

