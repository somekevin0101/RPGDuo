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
    public class CasinoMenu
    {
        public void Display()
        {
            Console.WriteLine("The smell of sour beer fills the room, it appears you can choose to play a game or drink beer");
            while (true)
            {
                Console.WriteLine("(1) Buy some beer");
                Console.WriteLine("(2) Play roulette");
                Console.WriteLine("(3) Listen for rumors");
                Console.WriteLine("(Q) Leave the Casino");

                string input = Console.ReadLine().ToUpper();

                if (input == "1" || input == "(1)")
                {
                    Console.WriteLine("The barkeep asks you how many beers you want");
                    Console.WriteLine("");

                }
                else if (input == "2" || input == "(2)")
                {
                    Console.WriteLine("An unscrupulous character asks you to place a bet");
                    Console.WriteLine("");

                }
                else if (input == "3" || input == "(3)")
                {
                    Console.WriteLine("You walk through the casino and strike up a conversation with a talkative patron");
                    Console.WriteLine("");

                }

                else if (input == "Q" || input == "(Q)")
                {
                    Console.WriteLine("You leave the Casino");
                    Console.WriteLine("");
                    break;
                }
            }

        }
    }
}
