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
        private Hero player;
        private Enemy monster;

        public Combat(Hero player, Enemy monster)
        {
            this.player = player;
            this.monster = monster;
        }

        public Dictionary<string,string> PlayerGetStatus()
        {
            // Returns a Dictionary<string,string> of Stat Name: Status Value
            throw new NotImplementedException();
        }
        public void PlayerTakeTurn()
        {
            throw new NotImplementedException();
        }
        public void PlayerAttackMonster()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string,string> MonsterGetStatus()
        {
            // Returns a Dictionary<string,string> of Stat Name: Status Value
            throw new NotImplementedException();
        }
        public void MonsterTakeTurn()
        {
            throw new NotImplementedException();
        }
        public void MonsterAttackPlayer()
        {
            throw new NotImplementedException();
        }

        public bool IsCombatOver()
        {
            throw new NotImplementedException();
        }
        public void EndCombat()
        {
            throw new NotImplementedException();
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
