using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public abstract class Weapon : IItem
    {
        protected int cost;
        public int Cost
        {
            get { return this.cost; }
        }

        protected int baseDamage;
        public int BaseDamage
        {
            get { return this.baseDamage; }
        }
        //actual damage done by weapon, for example a baseDamage of 15 would result in actual damage 0-30. 
        // was thinking this would be added to a default damage value from the hero that depends on their class
        public int DamageDealt()
        {
            Random random = new Random();
            int randomDamage = (baseDamage * random.Next(1, 100)) / 50;
            return randomDamage;
        }
        // method to be run each time you strike 1 in 50 chance weapon is destroyed
        // need remove weapon method that takes the output of this as an input (overload of a method with no arguments) 
        public bool IsDestroyed()
        {
            Random random = new Random();
            return (random.Next(1, 50) == 1);
        }

        public virtual void UseItem(Hero hero)
        {
            Console.WriteLine("you ended up hurting yourself, - 20 HP");
            hero.ChangeHitPoints(-20);
            hero.IsDead();
        }

    }
}
