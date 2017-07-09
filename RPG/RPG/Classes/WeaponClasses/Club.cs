using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.WeaponClasses
{
    public class Club : Weapon
    {
        public Club()
        {
            cost = 15;
            baseDamage = 7;
            itemName = "Club";
        }
     
    }
}
