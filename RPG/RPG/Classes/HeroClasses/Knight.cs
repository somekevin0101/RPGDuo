﻿using RPG.Classes.WeaponClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.HeroClasses
{
    public class Knight : Hero, IFight
    {
        public Knight(string name)
        {
            this.name = name;
            maxHitPoints = 100;
            currentHitPoints = 100;
            maxEndurance = 15;
            endurance = 15;
            EquippedWeapon = new BareHands();
            maxStrength = 12;
            strength = 12;
            money = 25;
            luck = 5;
            reputation = 15;
            Quests = new Dictionary<string, bool>();
        }

    }
}
