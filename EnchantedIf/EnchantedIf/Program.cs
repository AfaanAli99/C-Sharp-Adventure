using System;

namespace EnchantedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int temprature = -5 ;
            string stateOfmatter;

            if (temprature < 0)
                stateOfmatter = "solid";
            else
                stateOfmatter = "Liquid";

            Console.WriteLine($"State of matter is {stateOfmatter}");
            temprature += 30;


            stateOfmatter = temprature < 0 ? "Solid" : "Liquid";

            temprature += 100;
            stateOfmatter = temprature > 100 ? "Gas" : temprature < 0 ? "Solid" : "Liquid";

            Console.WriteLine($"State of matter is {stateOfmatter}");
        }
    }
}

