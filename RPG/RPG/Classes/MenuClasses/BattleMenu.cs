using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes.EnemyClasses;
using RPG.Classes.HeroClasses;
using RPG.Classes.MenuClasses;
using RPG.Classes;
using RPG.Classes.Combat;

namespace RPG.Classes.MenuClasses
{
    public class BattleMenu
    {
        public void Display(Hero player)
        {
            CombatCLI combat = new CombatCLI();

            Console.WriteLine("You enter a large arena, a few local citizens watch from the stands");
            while (true)
            {
                Console.WriteLine("(1) Fight a random monster");
                Console.WriteLine("(2) Watch someone else fight");
                Console.WriteLine("(Q) Leave the arena");

                string input = Console.ReadLine().ToUpper();

                if (input == "1" || input == "(1)")
                {
                    if(player.Name == "Boogersnot")
                    {
                        Console.WriteLine("You enter the arena and as you walk around a large crowd fills the stadium.");
                        Console.WriteLine("The crowd begins to chant 'BOOGERSNOT! BOOGERSNOT! BOOGERSNOT! BOOGERSNOT'");
                    }

                    combat.HeroFightMonster(player);
                }

                else if (input == "2" || input == "(2)")
                {
                    combat.MonsterFightMonster();
                }

                else if (input == "Q" || input == "(Q)")
                {
                    Console.WriteLine("You head back into town");
                    Console.WriteLine("");
                    break;
                }
            }

        }

    }
}
