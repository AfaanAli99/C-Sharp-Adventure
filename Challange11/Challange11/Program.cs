using System;

namespace Challange11
{
    class Program
    {
        static void Main(string[] args)
        { }
            static void GetOdd(int[] Array)
            {
                foreach (int i in Array)
                {
                    if (i != i % 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            static void GetEven(int[] Array)
            {
                foreach (int i in Array)
                {
                    if (i == i % 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            static void Run()
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                GetOdd(array);
                GetEven(array);

            }
        
    }
}

