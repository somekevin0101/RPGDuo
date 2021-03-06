﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public interface IItem
    {
        string ItemName {get;}
        int Cost { get;}
        void UseItem(Hero hero);
        int DamageDealt();
    }
}
