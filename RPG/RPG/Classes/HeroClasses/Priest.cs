using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.HeroClasses
{
    public class Priest : Hero, ICharacter
    {
        public Priest(string name)
        {
            this.name = name;
            maxHitPoints = 100;
            currentHitPoints = 100;
            maxEndurance = 7;
            endurance = 7;
            maxStrength = 7;
            strength = 7;
            money = 15;
            luck = 10;
        }

    }
}
