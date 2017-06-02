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
    public class TownMenu
    {
        int parsedHeroChoice = 0;
        string name = "";

        public void Display()
        {
            Console.WriteLine("DARKNESS........");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("You hear a low rumbling voice. A powerfull voice and yet the words are indistint. Fragments of their speech");
            Console.WriteLine("can be heard... hero.... begin again.... save..... lost....");
            Console.WriteLine("");
            Console.WriteLine("The darkness begins to fade and you realize you must make a choice about your nature");

            HeroSelector selector = new HeroSelector();
            Console.WriteLine("Choose the type of hero you want to be (enter number)");
            Console.WriteLine("(1) Knight");
            Console.WriteLine("(2) Thug");
            Console.WriteLine("(3) Priest");
            Console.WriteLine("(4) Barbarian");
            Console.WriteLine("(5) Archer");

            string userHeroChoice = Console.ReadLine();
            Int32.TryParse(userHeroChoice, out parsedHeroChoice);


            var player = selector.SelectHero(parsedHeroChoice);

            Console.WriteLine("You're alive " + player.Name + ", and you find yourself a bit dazed and confused");
            Console.WriteLine("at the entrance of a town.......");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("Choose the location you want to visit in the town");
                Console.WriteLine("(1) Thurgrand's Assorted Goods and Weapons");
                Console.WriteLine("(2) Battle Arena");
                Console.WriteLine("(3) Lucky Lia's Games and Drink");
                Console.WriteLine("(4) Town Council Hall");
                Console.WriteLine("(5) The Hog's Tail Inn");
                Console.WriteLine("(Q) Quit Game");

                string input = Console.ReadLine();

                if (input == "1" || input == "(1)")
                {
                    StoreMenu store = new StoreMenu();
                    store.Display();

                }
                else if (input == "2" || input == "(2)")
                {
                    BattleMenu battle = new BattleMenu();
                    battle.Display();
                }
                else if (input == "3" || input == "(3)")
                {
                    CasinoMenu casino = new CasinoMenu();
                    casino.Display();
                }
                else if (input == "4" || input == "(4)")
                {
                    HallMenu hall = new HallMenu();
                    hall.Display();
                }
                else if (input == "5" || input == "(5)")
                {
                    InnMenu inn = new InnMenu();
                    inn.Display();
                }

                else if (input == "Q" || input == "q" || input == "(Q)" || input == "(q)")
                {
                    Console.WriteLine("Game Over!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }

            }

        }

    }
}
