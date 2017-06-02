﻿using System;
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
    public class BattleMenu
    {
        public void Display()
        {
            Console.WriteLine("You enter a large arena, a few local citizens watch from the stands");
            while (true)
            {
                Console.WriteLine("(1) Fight a random monster");
                Console.WriteLine("(2) Watch someone else fight");
                Console.WriteLine("(Q) Leave the arena");

                string input = Console.ReadLine().ToUpper();

                if (input == "1" || input == "(1)")
                {
                    Console.WriteLine("Get ready for battle");
                }
                else if (input == "2" || input == "(2)")
                {
                    Console.WriteLine("You wait an hour in the stands, and then a hero enters the arena asking to fight");
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
