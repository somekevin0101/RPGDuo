using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class HealthPotion : IItem
    {
        // check on if has potion will happen in CLI object
        public void UseItem(Hero hero)
        {
            hero.ChangeHitPoints(20);
        }
    }
}
