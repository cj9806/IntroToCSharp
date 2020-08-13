using System;

namespace Varibles_Operators_And_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "hello, user! the game's start condition is: ";
            bool gameStarted = false;
            string displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);

            gameStarted = true;
            displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);
            Console.ReadKey();
            //comment
        }
    }
}
