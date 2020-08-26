using System;

namespace LoopsExercise
{
    class Program
    {
        static void Main()
        {
            int score = 0;
            int loopCount = 1;
            int loopTrack = 1;
            Console.WriteLine("while loop counter.");
            while(loopCount <= 10)
            {
                Console.WriteLine(loopTrack);
                loopTrack += 1;
                loopCount += 1;
            }
            Console.WriteLine("for loop counter");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                if (score < 100)
                {
                    score += 20;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("second for loop counter");
            for (int i = 1; i <= 150; i += 20)
            {
                Console.WriteLine(i);
                if (i > 100)
                {
                    break;
                }
            }

        }

    }
}
