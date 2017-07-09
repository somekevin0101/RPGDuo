using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class Dagger : Weapon
    {
        public Dagger()
        {
            cost = 10;
            baseDamage = 4;
            itemName = "Dagger";
        }
    }
}
