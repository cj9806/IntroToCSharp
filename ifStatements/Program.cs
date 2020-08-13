using System;

namespace ifStatements
{
    class Program
    {
        static void Main()
        {
            bool playerAlive = true;
            int invulnTimer = 5;
            if (playerAlive)
            {
                Console.WriteLine("The player is still alive.");
            }
            else
            {
                Console.WriteLine("the player is dead.");
            }

            invulnTimer -= 1;
            if (invulnTimer > 0)
            {
                Console.WriteLine("you have " + invulnTimer + " seconds of invulnrability left.");
                if (playerAlive)
                {
                    invulnTimer -= 1;
                }
            }
            else if(invulnTimer == 0)
            {
                Console.WriteLine("you can now take damage!");
            }
            else if(invulnTimer < 0)
            {
                invulnTimer = 0;
            }
        }
    }
}
