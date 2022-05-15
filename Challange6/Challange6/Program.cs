using System;

namespace Challange6
{
    class Program
    {
        static int highScore = 123;
        static string highScorePlayer = "AfaanAli";

        static void Main(string[] args)
        {
            CheckHighScore(122, "Batman");
            CheckHighScore(132, "Bittu");
        }
        public static void CheckHighScore(int score, string newPlayer)
        {
            if (score > highScore)
            {
                Console.WriteLine("Enter your name");
                newPlayer = Console.ReadLine();
                Console.WriteLine($"New High score is {score}");
                Console.WriteLine($"New High score holder is {newPlayer}");
            }
            else
            {
                Console.WriteLine($"The old highscore of {highScore} could not be broken and is still held by {highScorePlayer}");
            }
        }
    }
}

