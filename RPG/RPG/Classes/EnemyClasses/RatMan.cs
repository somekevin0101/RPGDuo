using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.EnemyClasses
{
    public class RatMan : Enemy, IFight
    {
        public RatMan()
        {
            maxHitPoints = 50;
            currentHitPoints = 50;
            baseDamage = 5;
            endurance = 5;
            reputationIncreaseUponDeath = 10;

        }

        public override void DeathShriek()
        {
            Console.WriteLine("SSQQQEEEEEEKKK SSSQQQUEEEEEK.....squeek");
        }

    }
}
