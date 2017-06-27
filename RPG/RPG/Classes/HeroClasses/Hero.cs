using RPG.Classes.WeaponClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public abstract class Hero : IFight
    {

        protected string name;
        public string Name
        {
            get { return this.name; }
        }

        protected int maxHitPoints;
        public int MaxHitPoints
        {
            get { return this.maxHitPoints; }
        }

        protected int currentHitPoints;
        public int CurrentHitPoints
        {
            get { return this.currentHitPoints; }
        }

        protected int maxStrength;
        public int MaxStrength
        {
            get { return this.maxStrength; }
        }

        protected int strength;
        public int Strength
        {
            get
            {
                if (beersDrunk > 0 && beersDrunk < 3)
                {
                    return this.strength + 10;
                }
                else if (beersDrunk >= 3 && beersDrunk < 10)
                {
                    return this.strength - 5;
                }
                else if (beersDrunk >= 10)
                {
                    return this.strength - 10;
                }
                else
                {
                    return this.strength;
                }

            }
        }

        protected int money;
        public int Money
        {
            get { return this.money; }
        }

        protected int reputation;
        public int Reputation
        {
            get { return this.reputation; }
        }

        protected int maxEndurance;
        public int MaxEndurance
        {
            get { return this.maxEndurance; }
        }

        // modifies how much damage is done by enemy, kinda like armor and toughness combined
        // need to add modifier to fight method
        protected int endurance;
        public int Endurance
        {
            get
            {
                if (beersDrunk > 0 && beersDrunk < 3)
                {
                    return this.endurance + 10;
                }
                else if (beersDrunk >=3 && beersDrunk < 10)
                {
                    return this.endurance - 5;
                }
                else if (beersDrunk >= 10)
                {
                    return this.endurance - 10;
                }

                return this.endurance;
            }
        }

        protected int luck;
        public int Luck
        {
            get { return this.luck; }
        }

        protected double gamblingAttempts;
        public double GamblingAttempts
        {
            get { return this.gamblingAttempts; }
        }

        protected double gamblingSuccesses;
        public double GamblingSuccesses
        {
            get { return this.gamblingSuccesses; }
        }

        protected bool isTooLucky;
        public bool IsTooLucky
        {
            get
            {
                if (gamblingAttempts < 6)
                {
                    return false;
                }
                else if ((gamblingSuccesses / gamblingAttempts) >= .75)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsDead { get; set; }

        protected int beersDrunk;
        public int BeersDrunk
        {
            get { return this.beersDrunk; }
        }

        protected List<IItem> inventoryList = new List<IItem>();
        public List<IItem> InventoryList
        {
            get { return this.inventoryList; }
        }

        public void ChangeHitPoints(int changedAmount)
        {
            if (changedAmount > 200)
            {
                currentHitPoints += 200;
            }
            else if (changedAmount < -200)
            {
                currentHitPoints += -200;
            }
            else
            {
                currentHitPoints += changedAmount;

            }
        }
        public void ChangeReputation(int changedAmount)
        {
            reputation += changedAmount;
        }
        public void ChangeMoney(int changedAmount)
        {
            if (changedAmount > 1000)
            {
                changedAmount += 1000;
            }
            else if (changedAmount < -1000)
            {
                changedAmount += -1000;
            }
            else
            {
                money += changedAmount;
            }
        }
        public void Rest()
        {
            beersDrunk = 0;
            strength = maxStrength;
            endurance = maxEndurance;

            if (currentHitPoints < maxHitPoints)
            {
                currentHitPoints = maxHitPoints;
            }

            Console.WriteLine("your current hitpoints is " + currentHitPoints);
            Console.WriteLine("your strength and endurance have been restored to maximum");
            Console.WriteLine("");

        }

        public void AddItem(IItem item)
        {
            inventoryList.Add(item);
        }



        public bool GetDeathStatus()
        {
            if (this.currentHitPoints > 0)
            {
                return false;
            }
            else
            {
                IItem item = inventoryList.Where(i => i.GetType() == typeof(HealthPotion)).FirstOrDefault();

                bool containsHealthPotion = item != null;

                if (!containsHealthPotion) return true;

                Console.WriteLine("Do you want to drink your potion with your last dying breath? YES/NO");
                string userInput = Console.ReadLine().ToUpper();
                if (userInput == "Y" || userInput == "YES")
                {
                    Console.WriteLine();
                    Console.WriteLine("drinking potion");

                    item.UseItem(this);

                    if(this.currentHitPoints <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You feel the potion try to heal you but the damage is far too great....");
                    }

                    inventoryList.Remove(item);

                }

                return (this.currentHitPoints <= 0);

            }
        }

        public virtual void BuyBeer(int numberOfBeers)
        {
            money -= Math.Abs(numberOfBeers * 2);
            Console.WriteLine("your current number of coins is " + money);
            Console.WriteLine("");
        }

        public virtual void DrinkBeer(int numberOfBeers)
        {
            // it does not pay to try to cheat the barkeep
            if (numberOfBeers < 0)
            {
                Console.WriteLine("the barkeep uses an arcane absolute value calculation and charges you accordingly");
                Console.WriteLine("no beer for you and your reputation suffers");
                Console.WriteLine("");

                reputation -= 5;

                numberOfBeers = 0;
            }

            beersDrunk += numberOfBeers;

            if ((beersDrunk > 0) && (beersDrunk <= 2))
            {
                Console.WriteLine("you feel a bit stronger now");
                Console.WriteLine("");
            }
            else if ((beersDrunk > 2) && (beersDrunk <= 10))
            {
                Console.WriteLine("you're feeling a bit tipsy");
                Console.WriteLine("");
            }
            else if (beersDrunk > 10)
            {

                reputation -= 5;

                Console.WriteLine("you better not fight in this condition buddy, you're drunk");
                Console.WriteLine("go rest at the inn and sleep it off");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }
        }

        public virtual int DamageDone()
        {
            Random random = new Random();
            int baseDamage = (strength * random.Next(1, 100)) / 50;
            return baseDamage;
        }

        public void GamblingAttemptsCounter()
        {
            gamblingAttempts++;
        }

        public void GamblingSuccessesCounter()
        {
            gamblingSuccesses++;
        }

    }
}
