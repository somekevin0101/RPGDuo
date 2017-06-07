using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.EnemyClasses
{
    public class Ogre: Enemy, IFight
    {
        public Ogre()
        {
            maxHitPoints = 150;
            currentHitPoints = 150;
            baseDamage = 15;
            endurance = 15;
            reputationIncreaseUponDeath = 50;

        }

        public override void DeathShriek()
        {
            Console.WriteLine("");
            Console.WriteLine("Death never takes a wise man by suprise; he is always ready to go");
            Console.WriteLine("");
        }

    }
}
