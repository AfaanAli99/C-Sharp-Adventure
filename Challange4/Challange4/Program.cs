using System;

namespace Challange4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fri1 = "Afaan";
            string fri2 = "Gohan";
            string fri3 = "Levi";

            GreetFriend(fri1,20);
            GreetFriend(fri2,40);
            GreetFriend(fri3,50);
        }

        public static void GreetFriend(string friendName, int age)
        {
            Console.WriteLine($"hi {friendName} how are you? are you {age} years old?");
        }
       
    }
}

