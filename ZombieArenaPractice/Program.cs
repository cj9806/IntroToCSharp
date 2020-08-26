using System;
using System.ComponentModel.Design;
using ZombieArenaPractice;

class Program
{
    static void Main(string[] args)
    {
        //new classes
        QualityOfLife qol = new QualityOfLife();
        Player player = new Player();
        Zombie zombie = new ArmoredZombie();
        

        // introduction text
        Console.WriteLine("Welcome to the Zombie Arena");

        // controls whether battle should continue
        bool isBattleOver = false; ;

        // battle loop
        while (!isBattleOver)
        {
            // prompt the player for input
            //put choices into array
            string[] choices = new string[7] { "help", "quit", "check health", "am I alive", "attack", "hide", "heal"};
            string help = choices[0];
            string checkHealth = choices[1];
            string amAlive = choices[2];
            string attack = choices[3];
            string hide = choices[4];
            string heal = choices[5];
            string quit = choices[6];
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("your choices are:");
            Console.WriteLine(help);//do it later
            Console.WriteLine(quit);
            Console.WriteLine(checkHealth);
            Console.WriteLine(amAlive);
            Console.WriteLine(attack);
            Console.WriteLine(hide);
            Console.WriteLine(heal);
            //player turn
            string playerChoice = Console.ReadLine();
            
            //help
            if (playerChoice == choices[0])
            {
                Console.WriteLine(help + ": this is where you are now");
                Console.WriteLine(quit + ": quit the game");
                Console.WriteLine(checkHealth + ": seehow much health you have left");
                Console.WriteLine(amAlive + ": see if your still alive");
                Console.WriteLine(attack + ": hit the zombie");
                Console.WriteLine(hide + ": hide from attacks");
                Console.WriteLine(heal + ": lick your wounds and recover health, can only be done while hiding");
                Console.ReadLine();
                continue;
            }
            //quit
            else if (playerChoice == choices[1])
            {
                break;
            }
            //check health
            else if (playerChoice == choices[2])
            {
                Console.WriteLine($"you have {player.healthPoints} health left");
                Console.ReadLine();
                continue;
            }
            //am alive
            else if (playerChoice == choices[3]) 
            {
                Console.WriteLine("you certinly hope so!");
                Console.ReadLine();
                continue;
            }
            //attack
            else if (playerChoice == choices[4])//attack
            {
                if (player.hiding)
                {
                    Console.WriteLine("you burst from cover and attack the zombie");
                    player.hiding = false;
                }
                else
                {
                    Console.WriteLine($"you move to attack the zombie, it takes {player.Attack()} damage");
                }
                zombie.health -= player.Attack();
                Console.ReadLine();
            }
            //hide
            else if (playerChoice == choices[5] && !player.hiding)
            {
                player.Hide();
                Console.WriteLine("you duck into cover to hide from the zombies attacks");
                Console.ReadLine();
            }
            //healing
            else if (playerChoice == choices[6])
            {
                //make sure player is  hiding first
                if (player.hiding)
                {
                    player.healthPoints += 15;
                    Console.WriteLine("you heal for 15 points");
                }
                else
                {
                    Console.WriteLine("healing out in the open isnt a good idea");
                    continue;
                }
                //make sure you dont go over max health
                if (player.healthPoints > 100)
                {
                    player.healthPoints = 100;
                }
                Console.ReadLine();
            }
            //for test purposes
            else if (playerChoice == "wait")
            {

            }
            //failsafe
            else
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();
                continue;
            }
            

            
            // win loss condition
            if (player.IsDefeated)
            {
                Console.WriteLine("You fall to the ground defeated, the world fading to black");
                break;
            }
            if (zombie.IsDefeated)
            {
                Console.WriteLine("You stand victorious to live another day");
            }
            
            Console.WriteLine("the zombie attacks you, you take 20 damage");
            player.TakeDamage(zombie.Attack());
            Console.ReadLine();

        }

        // good-bye text
        Console.WriteLine("Thanks for playing! Press ENTER to exit.");
        Console.ReadLine();

        return;
    }
}