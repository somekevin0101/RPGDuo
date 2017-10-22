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

        public Combat(IFight combatant1, IFight combatant2)
        {
            this.combatant1 = combatant1;
            this.combatant2 = combatant2;
        }

        public IFight TwoCharacterCombat()
        {
            while(combatant1.CurrentHitPoints> 0 && combatant2.CurrentHitPoints > 0)
            {
                IFight result = CombatTurn(combatant1, combatant2);
                if (result != null) return result;
                result = CombatTurn(combatant2, combatant1);
                if (result != null) return result;
            }
            return null;
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

        private IFight CombatTurn(IFight attacker, IFight defender)
        {
            string attackerType = attacker.GetType().Name;
            string defenderType = defender.GetType().Name;
            const int massiveDamageThreshold = 15;

            int damage = CalculateDamage(attacker, defender);
            defender.ChangeHitPoints(-(damage));

            if(damage > massiveDamageThreshold)
            {
                Console.WriteLine("The crowd roars as ");
            }
            Console.WriteLine("The " + attackerType + " hits " + defenderType +
                " for " + damage + " damage");
            System.Threading.Thread.Sleep(1000);

            return defender.GetDeathStatus() ? attacker : null;
        }

        private int CalculateDamage(IFight attacker, IFight defender)
        {
            int damage = attacker.DamageDone() - (defender.Endurance / 5);
            return damage < 0 ? 0 : damage;
        }
    }
}
