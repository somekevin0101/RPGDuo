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
    public class HeroSelector
    {
        private string name = "";

        public Hero SelectHero(int parsedHeroChoice)
        {

            if (parsedHeroChoice == 1)
            {
                Console.WriteLine("You are a brave Knight, What is your name?");
                name = Console.ReadLine();
                Knight player = new Knight(name);
                return player;

            }
            else if (parsedHeroChoice == 2)
            {
                Console.WriteLine("You are a cruel Thug, What is your name?");
                name = Console.ReadLine();
                Thug player = new Thug(name);
                return player;
            }
            else if (parsedHeroChoice == 3)
            {
                Console.WriteLine("You are a devout Priest, What is your name?");
                name = Console.ReadLine();
                Priest player = new Priest(name);
                return player;
            }
            else if (parsedHeroChoice == 4)
            {
                Console.WriteLine("You are a big dumb Barbarian, What is your name?");
                name = Console.ReadLine();
                Barbarian player = new Barbarian(name);
                return player;
            }
            else if (parsedHeroChoice == 5)
            {
                Console.WriteLine("You are a cowardly Archer, What is your name?");
                name = Console.ReadLine();
                Archer player = new Archer(name);
                return player;
            }
            else
            {
                Console.WriteLine("you failed to enter a number between 1 and 5");
                Console.WriteLine("you must be a big dumb Barbarian. Your name is Boogersnot");
                Barbarian player = new Barbarian("Boogersnot");
                return player;
            }

        }

    }
}
