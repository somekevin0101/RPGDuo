using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class Dagger : Weapon, IItem
    {
        public Dagger()
        {
            cost = 10;
            baseDamage = 5;
        }
    }
}
