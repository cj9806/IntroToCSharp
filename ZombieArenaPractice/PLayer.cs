using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ZombieArenaPractice
{
    class Player
    {
        public bool hiding = false;
        public float healthPoints = 100;

        // Accepts an attack with the given number of damage points
        public void TakeDamage(float damagePoints)
        {
            // TODO: given an amount of damage points, modify the player's health
            if (hiding)
            {
                Console.WriteLine("you are hidden from the zombies attacks");
            }
            else
            {
                healthPoints -= damagePoints;
                
            }
        }

        public void Hide()
        {
            hiding = true;
        }

        // Returns the damage points dealt by this attack
        public float Attack()
        {
            // TODO: calculate the number of points of damage to deal and return it
            int attk = 10;
            hiding = false;
            return attk;
            
        }

        public bool IsDefeated
        {
            get
            {
                // TODO: how do we know if the player has been defeated?
                if (healthPoints > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        
    }
}
