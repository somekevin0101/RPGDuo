using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.EnemyClasses
{
    public class Dragon : Enemy, ICharacter
    {
        public Dragon()
        {
            maxHitPoints = 500;
            currentHitPoints = 500;
            baseDamage = 35;
            endurance = 20;
            reputationIncreaseUponDeath = 100;
        }
    }
}
