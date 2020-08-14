using System;

namespace Functions
{
    class Program
    {
        
        static void Main()
        {
            Game game = new Game();
            game.score = 100;
            game.Start(); //dont get hung up for over an hour by forgetting your goddamned parantheses
        }

    }
    class Game
    {
        public int score = 0;
        public void Start()
        {
            Console.WriteLine(score);
            for(int i = 1; i <= 3; i++)
            {
                PrintScore(50);
            }
        }
        public int AddToScore(int add)
        {
            score += add;
            return score;
        }
        public void PrintScore(int add)
        {
            Console.WriteLine("you scored: " + AddToScore(add));
        }
    }
}
