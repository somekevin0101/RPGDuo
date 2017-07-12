using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.EnemyClasses
{
    public class Goblin : Enemy, IFight
    {
        public Goblin()
        {
            maxHitPoints = 100;
            currentHitPoints = 100;
            strength = 12;
            endurance = 10;
            reputationIncreaseUponDeath = 30;
            name = "goblin";

        }
    }
}
