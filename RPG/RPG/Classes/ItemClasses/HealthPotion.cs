using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class HealthPotion : IItem
    {
        protected int cost;
        public int Cost
        {
            get { return this.cost; }
        }

        public HealthPotion()
        {
            cost = 10;
        }
        // check on if has potion will happen in CLI object
        public void UseItem(Hero hero)
        {
            hero.ChangeHitPoints(20);
        }
    }
}
