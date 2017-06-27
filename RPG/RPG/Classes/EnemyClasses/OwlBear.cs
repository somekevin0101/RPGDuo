using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.EnemyClasses
{
    public class OwlBear : Enemy, IFight
    {
        public OwlBear()
        {
            maxHitPoints = 75;
            currentHitPoints = 75;
            strength = 9;
            endurance = 9;
            reputationIncreaseUponDeath = 20;
            name = "owlbear";

        }

        public override void BattleCry()
        {
            Console.WriteLine("");
            Console.WriteLine("HOOT HOOT ROAARRRR!");
            Console.WriteLine("");
        }

    }
}
