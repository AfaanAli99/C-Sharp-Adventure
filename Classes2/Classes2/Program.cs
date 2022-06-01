using System;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Afaan = new Human("Afaan", "Ali", "Brown", 23);
            Afaan.IntroduceMyself();

            Human Bittu = new Human("Abhishek","Gorekar","Black");
            Bittu.IntroduceMyself();

            Console.WriteLine(Bittu.lastName);

            Bittu.lastName = "ben";
            Bittu.IntroduceMyself();

            Human Gohan = new Human("Gohan");
            Gohan.IntroduceMyself();
        }
    }
}

