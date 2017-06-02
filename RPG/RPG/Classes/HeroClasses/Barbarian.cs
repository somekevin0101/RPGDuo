using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.HeroClasses
{
    public class Barbarian : Hero, ICharacter
    {
        public Barbarian(string name)
        {
            this.name = name;
            maxHitPoints = 100;
            currentHitPoints = 100;
            maxEndurance = 15;
            endurance = 15;
            maxStrength = 12;
            strength = 12;
            money = 15;
            luck = 5;
            reputation = 10;
        }

    }
}
