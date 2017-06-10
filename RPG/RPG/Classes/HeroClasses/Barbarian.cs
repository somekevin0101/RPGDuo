using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.HeroClasses
{
    public class Barbarian : Hero, IFight
    {
        public Barbarian(string name)
        {
            this.name = name;
            maxHitPoints = 125;
            currentHitPoints = 125;
            maxEndurance = 15;
            endurance = 15;
            maxStrength = 13;
            strength = 13;
            money = 20;
            luck = 5;
            reputation = 10;
        }
    }
}
