using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.HeroClasses
{
    public class Archer : Hero, IFight
    {
        public Archer(string name)
        {
            this.name = name;
            maxHitPoints = 110;
            currentHitPoints = 110;
            maxEndurance = 13;
            endurance = 13;
            maxStrength = 11;
            strength = 11;
            money = 15;
            luck = 5;
            reputation = 10;
        }

    }
}
