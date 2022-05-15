using System; 

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string done = "done";
            while (done!= Console.ReadLine())
            {
                counter++;
                Console.WriteLine($"Current amount of people on the bus {counter}");
            }
            Console.WriteLine($"Total {counter} people are on the bus");
        }
    }
}

