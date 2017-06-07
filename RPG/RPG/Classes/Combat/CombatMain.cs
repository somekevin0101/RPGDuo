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

        public Combat(IFight fighterOne, IFight fighterTwo)
        {
            this.combatant1 = fighterOne;
            this.combatant2 = fighterTwo;
        }

        public Dictionary<string,string> Combatant1GetStatus()
        {
            // Returns a Dictionary<string,string> of Stat Name: Status Value
            throw new NotImplementedException();
        }
        public Dictionary<string, string> Combatant2GetStatus()
        {
            // Returns a Dictionary<string,string> of Stat Name: Status Value
            throw new NotImplementedException();
        }

        public void TakeTurn(IFight nextToAct)
        {
            throw new NotImplementedException();
        }
        public void PlayerAttacks()
        {
            throw new NotImplementedException();
        } // For now, all a player does is swing their weapon (bows suck)
        public void MonsterAttacks()
        {
            throw new NotImplementedException();
        }


        public bool IsCombatOver()
        {
            if (combatant1 is Hero)
            {
                Hero hero1 = (Hero)combatant1;
                if (hero1.IsDead(hero1))  // ?????????????????????
                    return true;
            }
        }
        public IFight returnWinner()
        {
            if (combatant1.currentHealth <= 0)
            {
                return combatant2;
            }
            else if (combatant2.currentHealth <= 0)
            {
                return combatant1;
            }

            return null;
        }
        public IFight returnLoser()
        {
            if (combatant1.currentHealth <= 0)
            {
                return combatant1;
            }
            else if (combatant2.currentHealth <= 0)
            {
                return combatant2;
            }

            return null;
        }

        public bool Calculate_AttackerHitDefender()
        {
            // There is no miss mechanic in the game at the moment.
            return true;
        }
        public void AttemptToFlee()
        {
            throw new NotImplementedException();
        }
    }
}
