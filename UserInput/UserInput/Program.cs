using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(Calculate());
        }

        public static int Calculate()
        {
            Console.WriteLine("Type a number to add");
            string UserInp1 = Console.ReadLine();
            Console.WriteLine("Type the second number");
            string UserInp2 = Console.ReadLine();

            int num1 = int.Parse(UserInp1);
            int num2 = int.Parse(UserInp2);

            int result = num1 + num2;
            return result;
        }
    }
}

