using System;

namespace Varibles_Operators_And_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello, user!";
            int playerScore = 0;
            string displayScore = "Your score currently is " + playerScore + ".";

            Console.WriteLine(greeting);
            Console.WriteLine(displayScore);
            Console.ReadKey();

        }
    }
}
