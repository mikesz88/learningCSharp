namespace Coding.Exercise
{
    public class Exercise
    {
        static int score, highscore;
        static string highscorePlayer;
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of the player?");
            string newPlayer = Console.ReadLine()!;
            Console.WriteLine($"What score did {newPlayer} get?");
            int newScore = int.Parse(Console.ReadLine()!);
            GameOver(newScore, newPlayer);
        }

        public static void GameOver(int score, string playerName)
        {
            if (score > highscore)
            {
                Console.WriteLine($"New highscore is {score}");
                Console.WriteLine($"New highscore holder is {playerName}");
                highscore = score;
                highscorePlayer = playerName;
            } else
            {
                Console.WriteLine($"The old highscore of {highscore} could not be broken and is still held by {highscorePlayer}");
            }
        }




    }
}