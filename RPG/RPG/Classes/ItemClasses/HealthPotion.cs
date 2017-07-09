using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class HealthPotion : IItem
    {

        public string ItemName
        {
            get { return "Health Potion"; }
        }


        protected int cost;
        public int Cost
        {
            get { return this.cost; }
        }


        public HealthPotion()
        {
            cost = 5;
        }
        // check on if has potion will happen in CLI object
        public void UseItem(Hero hero)
        {
            hero.ChangeHitPoints(20);
        }
        
        public int DamageDealt()
        {
            return 0;
        }
    }
}
