﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZombieArenaPractice
{
    class ArmoredZombie : Zombie
    {
        
        public float defensePoints = 5;

        // Accepts an attack with the given number of damage points
        public override void TakeDamage(float damagePoints)
        {
            // TODO: given an amount of damage points, modify the zombie's health
            //
            //       reduce the damage that the zombie takes by the number of defense points it has
            health -= (damagePoints - defensePoints);
        }
    }
}
