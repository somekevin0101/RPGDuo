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
            strength = 8;
            endurance = 1;
            reputationIncreaseUponDeath = 10;
            name = "ratman";
        }

        public override void BattleCry()
        {
            Console.WriteLine("");
            Console.WriteLine("SSQQQEEEEEEKKK SSSQQQUEEEEEK.....squeek");
            Console.WriteLine("");
        }

    }
}
