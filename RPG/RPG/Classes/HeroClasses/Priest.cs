using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.HeroClasses
{
    public class Priest : Hero, IFight
    {
        public Priest(string name)
        {
            this.name = name;
            maxHitPoints = 90;
            currentHitPoints = 90;
            maxEndurance = 7;
            endurance = 7;
            maxStrength = 7;
            strength = 7;
            money = 50;
            luck = 10;
            reputation = 30;
        }

        public override void DrinkBeer(int numberOfBeers)
        {
            if (numberOfBeers < 0)
            {
                Console.WriteLine("Can't believe you tried to pull that on me, a priest no less");
                Console.WriteLine("the barkeep uses an arcane absolute value calculation and charges you accordingly");
                Console.WriteLine("no beer for you and your reputation suffers");
                Console.WriteLine("");

                reputation -= 5;

                numberOfBeers = 0;
            }

            beersDrunk += numberOfBeers;
            if ((beersDrunk > 0) && (beersDrunk <= 2))
            {

                endurance += 10;
                strength += 10;

                Console.WriteLine("you feel a bit stronger now");
                Console.WriteLine("");
            }
            else if ((beersDrunk > 2) && (beersDrunk <= 10))
            {

                endurance -= 3;
                strength -= 3;

                Console.WriteLine("you're feeling a bit tipsy");
                Console.WriteLine("");
            }
            else if (beersDrunk > 10)
            {

                reputation -= 1;
                endurance -= 10;
                strength -= 10;

                Console.WriteLine("you better not fight in this condition buddy, you're drunk");
                Console.WriteLine("");
                Console.WriteLine("the barkeep begins to laugh and laugh. You're alright for a Priest....");
                Console.WriteLine("go rest at the inn and sleep it off");
                Console.WriteLine("");
            }
            else
            {
                beersDrunk = 0;
            }


        }
    }
}