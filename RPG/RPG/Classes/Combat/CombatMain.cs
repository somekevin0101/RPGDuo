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

        public Combat(IFight fighterOne, IFight fighterTwo)
        {
            this.combatant1 = fighterOne;
            this.combatant2 = fighterTwo;
            whoseTurn = 1;
        }

        private Dictionary<string,string> ReturnStatus(IFight fighterOfInterest)
        {
            // Returns a Dictionary<string,string> of Stat Name: Status Value
            throw new NotImplementedException();
        } 

        public bool CombatIsOver()
        {
            return (combatant1.IsDead() || combatant2.IsDead());
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

        public void drinkPotion(IFight potionDrinker)
        {
            if (potionDrinker is Hero)
            {
                ((Hero)potionDrinker).DrinkPotion();
            }
        }

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
