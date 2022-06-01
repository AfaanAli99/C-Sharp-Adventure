using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Afaan = new Human();
            Afaan.firstName = "Afaan";
            Afaan.lastName = "Ali";
            Afaan.IntroduceMyself();

            Human Bittu = new Human();
            Bittu.firstName = "Abhishek";
            Bittu.lastName = "Gorekar";
            Bittu.IntroduceMyself();
        }
    }
}

