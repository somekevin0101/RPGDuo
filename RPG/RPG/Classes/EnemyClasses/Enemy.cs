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
        public virtual void BattleCry()
        {
            Console.WriteLine("");
            Console.WriteLine("I'M GOING TO EAT YOU!!!");
            Console.WriteLine("");
        }
        public bool GetDeathStatus()
        {
            return CurrentHitPoints <= 0;
        }

        public void ChangeHitPoints(int changedAmount)
        {
            if (changedAmount > 200)
            {
                currentHitPoints += 200;
            }
            else if (changedAmount < -200)
            {
                currentHitPoints += -200;
            }
            else
            {
                currentHitPoints += changedAmount;

            }
        }

        public string name { get; set; }
    }
}
