﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes.EnemyClasses;

namespace RPG.Classes.Combat
{
    public class Combat
    {
        private IFight combatant1;
        private IFight combatant2;

        private int whoseTurn;
        public int WhoseTurn { get { return this.whoseTurn; } }

        public void BasicCombat(Hero fighterOne, Enemy fighterTwo)
        {
            while(fighterOne.CurrentHitPoints > 0 && fighterTwo.CurrentHitPoints > 0)
            {
                int damage = fighterOne.DamageDone();
                fighterTwo.ChangeHitPoints(-(damage));
                Console.WriteLine("The " + fighterOne.GetType().Name + " hits " + fighterTwo.GetType().Name +
                    " for " + damage + " damage");
                System.Threading.Thread.Sleep(1000);

                bool isDead = fighterTwo.GetDeathStatus();
                if (isDead)
                {
                    Console.WriteLine(fighterTwo.GetType().Name + "has lost");
                    fighterOne.ChangeReputation(fighterTwo.ReputationIncreaseUponDeath);
                    break;
                }

                damage = fighterTwo.DamageDone();
                fighterOne.ChangeHitPoints(-(damage));
                Console.WriteLine("The " + fighterTwo.GetType().Name + " hits " + fighterOne.GetType().Name +
                    " for " + damage + " damage");
                System.Threading.Thread.Sleep(1000);

                isDead = fighterOne.GetDeathStatus();
                if (isDead)
                {
                    Console.WriteLine("you have died!!!");
                    break;
                }
            }
            
        }

        public void MonsterVMonsterCombat(Enemy fighterOne, Enemy fighterTwo)
        {
            while (fighterOne.CurrentHitPoints > 0 && fighterTwo.CurrentHitPoints > 0)
            {
                const int massiveDamageThreshold = 10;

                int damage = fighterOne.DamageDone();
                fighterTwo.ChangeHitPoints(-damage);

                if (damage >= massiveDamageThreshold)
                {
                    Console.WriteLine("The crowd roars as the " + fighterOne.name + "hits the " + fighterTwo.name);
                }

                damage = fighterTwo.DamageDone();
                fighterOne.ChangeHitPoints(-damage);

                if (damage >= massiveDamageThreshold)
                {
                    Console.WriteLine("The crowd roars as the " + fighterTwo.name + "hits the " + fighterOne.name);
                }

            }
        }

        private Dictionary<string,string> ReturnStatus(IFight fighterOfInterest)
        {
            // Returns a Dictionary<string,string> of Stat Name: Status Value
            throw new NotImplementedException();
        } 

        //public bool CombatIsOver()
        //{
        //    return (combatant1.GetDeathStatus() || combatant2.GetDeathStatus());
        //}
        public IFight ReturnWinner()
        {
            if (combatant1.CurrentHitPoints <= 0)
            {
                return combatant2;
            }
            else if (combatant2.CurrentHitPoints <= 0)
            {
                return combatant1;
            }

            return null;
        }
        public IFight ReturnLoser()
        {
            if (combatant1.CurrentHitPoints <= 0)
            {
                return combatant1;
            }
            else if (combatant2.CurrentHitPoints <= 0)
            {
                return combatant2;
            }
            return null;
        }

        //public void drinkPotion(IFight potionDrinker)
        //{
        //    if (potionDrinker is Hero)
        //    {
        //        ((Hero)potionDrinker).DrinkPotion();
        //    }
        //}

        private bool Calculate_AttackerHitDefender()
        {
            // There is no miss mechanic in the game at the moment. Auto-returns true.
            return true;
        }
        private bool CanFlee()
        {
            return true;
        }

        
    }


}
