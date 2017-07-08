using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.WeaponClasses
{
    class BareHands : Weapon , IItem
    {
            public BareHands()
            {
                cost = 0;
                baseDamage = 0;
            }

    }
}
