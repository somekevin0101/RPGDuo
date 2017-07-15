using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes.EnemyClasses;
using RPG.Classes.HeroClasses;
using RPG.Classes.MenuClasses;
using RPG.Classes;

namespace RPG.Classes.MenuClasses
{
    public class HallMenu
    {
        public void Display(Hero player)
        {
            Console.WriteLine("A room with distinguished looking people sitting at a table");
            while (true)
            {
                Console.WriteLine("(1) Request to go on a quest");
                Console.WriteLine("(Q) Leave the Hall");

                string input = Console.ReadLine().ToUpper();

                if (input == "1" || input == "(1)")
                {
                    Console.WriteLine("We shall see if there is anything for someone of your reputation");
                    Console.WriteLine("");
                    if(player.Reputation > 100)
                    {
                        Console.WriteLine("We need a brave soul to restore order to the roads that lead");
                        Console.WriteLine("outside of our town");
                        Console.WriteLine("");
                        Console.WriteLine("Do you accept this quest?(Y/N)");
                        string userInput = Console.ReadLine().ToUpper();
                        if(userInput == "Y")
                        {
                            Console.WriteLine("Excellent!");
                            // quest method to follow
                        }
                        else
                        {
                            player.ChangeReputation(-10);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You are not a trustworthy character, we have no quests for you");
                    }

                }
                else if (input == "Q" || input == "(Q)")
                {
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine("");
                    break;
                }
            }

        }
    }
}
