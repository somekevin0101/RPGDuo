using RPG.Classes.EnemyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.Combat
{
    public class CombatCLI
    {
        private List<Enemy> combatDungeon = new List<Enemy>()
        {
            new Dragon(),
            new Goblin(),
            new Ogre(),
            new OwlBear(),
            new OwlBear(),
            new RatMan(),
            new RatMan(),
            new RatMan()
        };
        
        public void HeroFightMonster(Hero player)
        {
            Console.WriteLine("Get Ready to fight!!!");

            Random random = new Random();

            Enemy opponent = GetRandomCombatant(random);

            Console.WriteLine("From the murky dungeon a " + opponent.GetType().Name + " enters");
            Console.WriteLine();
            opponent.BattleCry();

            Combat combat = new Combat(player, opponent);
            IFight winner = combat.TwoCharacterCombat();
            CheckWinner(winner, player, opponent);
        }


        public void ScriptedBattle(Hero player, Enemy e) // Scripted battles for heroes vs players
                                                         // Probably going to be used mainly for quests.
        {
            Combat combat = new Combat(player, e);
            combat.TwoCharacterCombat();
        }

        public void MonsterFightMonster()
        {
            Console.WriteLine("You sit in the stands, the next monster fight begins soon....");

            Random random = new Random();

            Enemy monster1 = GetRandomCombatant(random);
            Enemy monster2 = GetRandomCombatant(random);

            Console.WriteLine("From opposite sides of the arena, a " + monster1.GetType().Name +
                " and a " + monster2.GetType().Name + " emerge");

            Combat combat = new Combat(monster1, monster2);
            IFight winner = combat.TwoCharacterCombat();
            winner.BattleCry();
            CrowdChant(winner);
        }

        private Enemy GetRandomCombatant(Random random)
        {
            int opponentIndex = random.Next(0, combatDungeon.Count);

            Enemy opponent = combatDungeon[opponentIndex];

            return opponent;
        }

        private void CheckWinner(IFight winner, Hero player, Enemy opponent)
        {
            if (winner == player)
            {
                player.ChangeReputation(opponent.ReputationIncreaseUponDeath);
                Console.WriteLine();
                Console.WriteLine(player.Name + " wins and reputation is increased by " + opponent.ReputationIncreaseUponDeath + " points");
                Console.WriteLine();
            }
            else
            {
                // allows for an outcome where the hero fled but is still alive
                if(player.CurrentHitPoints <= 0)
                {
                    player.IsDead = true;
                    Console.WriteLine(player.Name + " is dead");
                }
                else
                {
                    Console.WriteLine("better luck next time");
                }
            }
        }

        private void CrowdChant(IFight winner)
        {
            string winnerType = winner.GetType().Name.ToUpper();
            Console.WriteLine("The crowd chants " + winnerType + "! " + winnerType + "! " + winnerType + "!");
            Console.WriteLine();
        }
    }
}
