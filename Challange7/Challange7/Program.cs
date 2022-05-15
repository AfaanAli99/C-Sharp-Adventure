using System;

namespace Challange7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter current temprature");
            string userInput = Console.ReadLine();
            string tempratureMessage = string.Empty;
            int temprature;
            bool Validnum = int.TryParse(userInput, out temprature);

            if (Validnum)
            {
                tempratureMessage = temprature <= 15 ?
                    "It is too cold" :
                    (temprature >=16 && temprature <=28) ?
                    "Its cold here" :
                    temprature >28 ? "It is hot here":"";
                Console.WriteLine(tempratureMessage);
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }
        }
    }
}

