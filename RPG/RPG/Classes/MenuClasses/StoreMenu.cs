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
    public class StoreMenu
    {
        public void Display()
        {
            Console.WriteLine("You see an aged warrior behind the counter. He asks you what you want to buy");
            while (true)
            {
                Console.WriteLine("(1) Buy a Weapon");
                Console.WriteLine("(2) Buy a Health Potion");
                Console.WriteLine("(Q) Leave the store");

                string input = Console.ReadLine().ToUpper();

                if (input == "1" || input == "(1)")
                {
                    Console.WriteLine("We have many fine weapons");
                    Console.WriteLine("");

                }
                else if (input == "2" || input == "(2)")
                {
                    Console.WriteLine("Hmm health potions taste awful but they do heal you");
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
