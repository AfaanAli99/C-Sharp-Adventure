using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;


            num3 = -num1;

            bool sun = true;
            
            

            int num = 0;
            num++;
            Console.WriteLine(num);
            Console.WriteLine(num++);
            Console.WriteLine(++num);
             
            num--;
            Console.WriteLine(num);
            Console.WriteLine(num--);
            Console.WriteLine(--num);

            int result;

            result = num1 + num2;
            Console.WriteLine($"result of {num1} + {num2} is {result}");
            result = num1 - num2;
            Console.WriteLine($"result of {num1} - {num2} is {result}");
            result = num1 / num2;
            Console.WriteLine($"result of {num1} / {num2} is {result}");
            result = num1 * num2;
            Console.WriteLine($"result of {num1} * {num2} is {result}");
            result = num1 % num2;
            Console.WriteLine($"result of {num1} % {num2} is {result}");

            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine(isLower);

            bool isLowerAndSunny;
            isLowerAndSunny = isLower || sun;
            Console.WriteLine(isLowerAndSunny);


        }
    }
    
   
    
    
}

