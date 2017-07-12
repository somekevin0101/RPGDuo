using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.EnemyClasses
{
    public class Dragon : Enemy, IFight
    {
        public Dragon()
        {
            maxHitPoints = 500;
            currentHitPoints = 500;
            strength = 30;
            endurance = 20;
            reputationIncreaseUponDeath = 100;
            name = "dragon";
        }

        public override void BattleCry()
        {
            Console.WriteLine("");
            Console.WriteLine("RRRRROOOOOOAAAAAAR!!!!!!! Cough cough.....");
            Console.WriteLine("");
        }
    }
}
