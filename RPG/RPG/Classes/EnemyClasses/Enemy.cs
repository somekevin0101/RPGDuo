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

        protected int baseDamage;
        public int BaseDamage
        {
            get { return this.baseDamage; }
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
            int randomDamage = (baseDamage * random.Next(1, 100)) / 50;
            return randomDamage;

        }
        public void Fight()
        {

        }

        public bool Flee()
        {
            return true;
        }
    }
}
