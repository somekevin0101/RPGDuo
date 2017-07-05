﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class BroadSword : Weapon, IItem
    {
        public BroadSword()
        {
            cost = 25;
            baseDamage = 10;
        }
    }
}
