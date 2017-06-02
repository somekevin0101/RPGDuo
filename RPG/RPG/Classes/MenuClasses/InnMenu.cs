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
    public class InnMenu
    {
        public void Display()
        {
            Console.WriteLine("You see an young woman behind a desk, she asks if you want a room for the night");
            while (true)
            {
                Console.WriteLine("(1) Purchase a room");
                Console.WriteLine("(Q) Leave the inn");

                string input = Console.ReadLine().ToUpper();

                if (input == "1" || input == "(1)")
                {
                    Console.WriteLine("Only the finest for a person of your repute");
                    Console.WriteLine("");

                }
                else if (input == "Q" || input == "(Q)")
                {
                    Console.WriteLine("Have a nice day");
                    Console.WriteLine("");
                    break;
                }
            }

        }
    }
}
