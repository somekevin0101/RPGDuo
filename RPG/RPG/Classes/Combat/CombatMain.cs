using System;
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
            this.whoseTurn = 1; // Start with combatant 1
            while (fighterOne.CurrentHitPoints > 0 && fighterTwo.CurrentHitPoints > 0)
            {
                this.whoseTurn = 1; // Combatant 1's turn!

                int damage = fighterOne.DamageDone();
                fighterTwo.ChangeHitPoints(-(damage)); // Apply damage
                Console.WriteLine("The " + fighterOne.GetType().Name + " hits " + fighterTwo.GetType().Name +
                    " for " + damage + " damage");
                System.Threading.Thread.Sleep(1000);

                bool isDead = fighterTwo.GetDeathStatus();
                if (isDead)
                {
                    Console.WriteLine();
                    Console.WriteLine(fighterTwo.GetType().Name + " has lost");
                    Console.WriteLine();
                    
                    fighterOne.ChangeReputation(fighterTwo.ReputationIncreaseUponDeath);
                    Console.WriteLine("Your reputation has increased by " + fighterTwo.ReputationIncreaseUponDeath + " points");
                    Console.WriteLine();
                    break;
                }

                this.whoseTurn = 2; //Combatant 2's turn!
                damage = (fighterTwo.DamageDone()) - (fighterOne.Endurance/5);
                if(damage < 0)
                {
                    damage = 0;
                }
                fighterOne.ChangeHitPoints(-(damage));
                Console.WriteLine("The " + fighterTwo.GetType().Name + " hits " + fighterOne.GetType().Name +
                    " for " + damage + " damage");
                System.Threading.Thread.Sleep(1000);

                isDead = fighterOne.GetDeathStatus();
                if (isDead)
                {
                    fighterOne.IsDead = true;
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
                    Console.WriteLine("The crowd roars as the ");
                }

                Console.WriteLine(fighterOne.GetType().Name + " hits the " + fighterTwo.GetType().Name +
                " for " + damage + " damage");

                bool isDead = fighterTwo.GetDeathStatus();
                if (isDead)
                {
                    fighterOne.BattleCry();

                    Console.WriteLine();
                    Console.WriteLine(fighterTwo.GetType().Name + " has lost");
                    Console.WriteLine("The crowd cheer and chants " + fighterOne.GetType().Name.ToUpper() + "! " +
                    fighterOne.GetType().Name.ToUpper() + "!");
                    Console.WriteLine();

                    break;
                }

                System.Threading.Thread.Sleep(1000);


                damage = fighterTwo.DamageDone();
                fighterOne.ChangeHitPoints(-damage);

                if (damage >= massiveDamageThreshold)
                {
                    Console.WriteLine("The crowd roars as the ");
                }

                Console.WriteLine("The " + fighterTwo.GetType().Name + " hits " + fighterOne.GetType().Name +
                " for " + damage + " damage");

                isDead = fighterOne.GetDeathStatus();
                if (isDead)
                {
                    fighterTwo.BattleCry();

                    Console.WriteLine();
                    Console.WriteLine(fighterOne.GetType().Name + " has lost");
                    Console.WriteLine("The crowd cheer and chants " + fighterTwo.GetType().Name.ToUpper() + "! " +
                        fighterTwo.GetType().Name.ToUpper() + "!");
                    Console.WriteLine();
                    
                    break;
                }

                System.Threading.Thread.Sleep(1000);


            }
        }

        private Dictionary<string,string> GetStatus(IFight fighterOfInterest)
        {
            // Returns a Dictionary<string,string> of Stat Name: Status Value
            throw new NotImplementedException();
        } 

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

        private bool AttackHits()
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
