using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int counter = 0; counter < 30; counter++)
            //{

            //    if (counter %2 == 0)
            //    {
            //        Console.WriteLine("next is odd");
            //        continue;
            //    }
            //    Console.WriteLine(counter);
            //}
            //Console.Read();


            int i = -10;

            while (i < -10 || i<=10)
            {
                Console.WriteLine(i);
                i++;
                

                if (i % 3 == 0)
                {
                    
                    continue;
                  
                }

                Console.WriteLine(i++);
            }
        }
    }
}
