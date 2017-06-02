﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.EnemyClasses
{
    public class Goblin : Enemy, ICharacter
    {
        public Goblin()
        {
            maxHitPoints = 100;
            currentHitPoints = 100;
            baseDamage = 10;
            endurance = 10;
            reputationIncreaseUponDeath = 20;

        }
    }
}