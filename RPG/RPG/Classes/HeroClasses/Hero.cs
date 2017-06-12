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
        static int potionsHealFor = 100;

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
                if(beersDrunk > 0 && beersDrunk < 3)
                {
                    return this.strength + 10;
                }
                else if(beersDrunk > 3 && beersDrunk < 10)
                {
                    return this.strength - 5;
                }
                else if (beersDrunk > 10)
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
                else if (beersDrunk > 3 && beersDrunk < 10)
                {
                    return this.endurance - 5;
                }
                else if (beersDrunk > 10)
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

        protected int beersDrunk;
        public int BeersDrunk
        {
            get { return this.beersDrunk; }
        }

        protected List<HealthPotion> potionList = new List<HealthPotion>();
        public List<HealthPotion> PotionList
        {
            get
            {
                { return this.potionList; }
                
            }
        }

        protected List<Weapon> weaponList = new List<Weapon>();
        public List<Weapon> WeaponList
        {
            get { return this.weaponList; }
        }

        public void ChangeHitPoints(int changedAmount)
        {
            if(changedAmount > 200)
            {
                currentHitPoints += 200;
            }
            else if(changedAmount < -200)
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
            if(changedAmount > 1000)
            {
                changedAmount += 1000;
            }
            else if(changedAmount < -1000)
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

            if(currentHitPoints < maxHitPoints)
            {
                currentHitPoints = maxHitPoints;
            }

            Console.WriteLine("your current hitpoints is " + currentHitPoints);
            Console.WriteLine("your strength and endurance have been restored to maximum");
            Console.WriteLine("");

        }
        public void AddPotion(HealthPotion potion)
        {
            potionList.Add(potion);
        }

        public void RemovePotion(List<HealthPotion> potion)
        {
            potion.RemoveAt(0);
        }

        public void AddWeapon(Weapon weapon)
        {
            weaponList.Add(weapon);
        }

        public bool HasPotion(List<HealthPotion> potion)
        {
            return (potion.Count > 0);
        }

        public bool HasWeapon(List<Weapon> weapon)
        {
            return (weapon.Count > 0);
        }

        public bool IsDead()
        {
            // logic on this method may need work
            while(true)
            {

                if ((currentHitPoints <= 0) && (HasPotion(potionList) == true))
                {
                    Console.WriteLine("Do you want to drink your potion with your last dying breath? YES/NO");
                    string userInput = Console.ReadLine().ToUpper();
                    if (userInput == "Y" || userInput == "YES")
                    {
                        Console.WriteLine("drinking potion");
                        potionList[0].UseItem(this);
                        potionList.RemoveAt(0);

                    }
                    else return currentHitPoints <= 0;

                }
                
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
            if(numberOfBeers < 0)
            {
                Console.WriteLine("the barkeep uses an arcane absolute value calculation and charges you accordingly");
                Console.WriteLine("no beer for you and your reputation suffers");
                Console.WriteLine("");

                reputation -= 5;

                beersDrunk += Math.Abs(numberOfBeers);
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
                beersDrunk = 0;
            }
        }
        // to be added to damage from weapon (or 0 if no weapon)
        public void DrinkPotion()
        { 
            if (!HasPotion(potionList))
            {
                return;
            }
            else
            {
                currentHitPoints += potionsHealFor;
                if (currentHitPoints > MaxHitPoints)
                {
                    currentHitPoints = maxHitPoints;
                }
                RemovePotion(potionList);
            }

        }

        public virtual int DamageDone()
        {
            Random random = new Random();
            int baseDamage = (strength * random.Next(1, 100)) / 100;
            return baseDamage;
        }

    }
}
