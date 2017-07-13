using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.WeaponClasses
{
    class BareHands : Weapon
    {
            public BareHands() // Bear Hands have the same stats and cost as a mace
            {
                cost = 15;
                baseDamage = 7;
                itemName = "Bear Hands";
            }

    }
}
