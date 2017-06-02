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
        public void Display()
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

                }
                else if (input == "Q" || input == "(Q)")
                {
                    Console.WriteLine("Happy Hunting!");
                    Console.WriteLine("");
                    break;
                }
            }

        }
    }
}
