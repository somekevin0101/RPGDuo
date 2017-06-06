using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.HeroClasses
{
    public class Barbarian : Hero, IFight
    {
        public Barbarian(string name)
        {
            this.name = name;
            maxHitPoints = 125;
            currentHitPoints = 125;
            maxEndurance = 15;
            endurance = 15;
            maxStrength = 13;
            strength = 13;
            money = 20;
            luck = 5;
            reputation = 10;
        }

        public override void DrinkBeer(int numberOfBeers)
        {
            if (numberOfBeers < 0)
            {
                Console.WriteLine("the barkeep uses an arcane absolute value calculation and charges you accordingly");
                Console.WriteLine("no beer for you and your reputation suffers");
                Console.WriteLine("");

                endurance -= 5;
                strength -= 5;
                reputation -= 5;

                beersDrunk += Math.Abs(numberOfBeers);
            }

            beersDrunk += numberOfBeers;

            if ((beersDrunk > 0) && (beersDrunk <= 3))
            {

                endurance += 5;
                strength += 5;

                Console.WriteLine("you feel a bit stronger now");
                Console.WriteLine("");
            }
            else if ((beersDrunk > 3) && (beersDrunk <= 15))
            {

                endurance -= 3;
                strength -= 3;

                Console.WriteLine("you're feeling a bit tipsy");
                Console.WriteLine("");
            }
            else if (beersDrunk > 15)
            {

                reputation -= 5;
                endurance -= 10;
                strength -= 10;

                Console.WriteLine("you better not fight in this condition buddy, you're drunk");
                Console.WriteLine("");
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