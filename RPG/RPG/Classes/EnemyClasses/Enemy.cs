using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.EnemyClasses
{
    public abstract class Enemy : IFight
    {
        protected int maxHitPoints;
        public int MaxHitPoints
        {
            get { return this.maxHitPoints; }
        }

        protected int currentHitPoints;
        public int CurrentHitPoints
        {
            get { return this.currentHitPoints; }
        }

        protected int strength;
        public int Strength
        {
            get { return this.strength; }
        }

        protected int endurance;
        public int Endurance
        {
            get { return this.endurance; }
        }

        protected int reputationIncreaseUponDeath;
        public int ReputationIncreaseUponDeath
        {
            get { return this.reputationIncreaseUponDeath; }
        }
        public int DamageDone()
        {
            Random random = new Random();
            int randomDamage = (strength * random.Next(1, 100)) / 50;
            return randomDamage;

        }
        public virtual void DeathShriek()
        {
            Console.WriteLine("");
            Console.WriteLine("Arrrrrrghhhhh I'm Deaaaad!!!!");
            Console.WriteLine("");
        }
        public bool GetDeathStatus()
        {
            return CurrentHitPoints <= 0;
        }

    }
}
