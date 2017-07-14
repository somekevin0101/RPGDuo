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

            Combat combat = new Combat();

            combat.BasicCombat(player, opponent);

        }

        public void ScriptedBattle(Hero player, Enemy e) // Scripted battles for heroes vs players
                                                         // Probably going to be used mainly for quests.
        {
            Combat combat = new Combat();
            combat.BasicCombat(player, e);
        }

        public void MonsterFightMonster()
        {
            Console.WriteLine("You sit in the stands, the next monster fight begins soon....");

            Random random = new Random();

            Enemy monster1 = GetRandomCombatant(random);
            Enemy monster2 = GetRandomCombatant(random);

            Console.WriteLine("From opposite sides of the arena, a " + monster1.GetType().Name +
                " and a " + monster2.GetType().Name + " emerge");

            Combat combat = new Combat();
            combat.MonsterVMonsterCombat(monster1, monster2);
        }

        public Enemy GetRandomCombatant(Random random)
        {
            int opponentIndex = random.Next(0, combatDungeon.Count);

            Enemy opponent = combatDungeon[opponentIndex];

            return opponent;
        }
    }
}
