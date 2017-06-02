using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public abstract class Hero : ICharacter
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
            get { return this.strength; }
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
            get { return this.endurance; }
        }
        protected int luck;
        public int Luck
        {
            get { return this.luck; }
        }

        protected List<HealthPotion> potion;
        public List<HealthPotion> Potion
        {
            get { return this.potion; }
        }
        protected List<Weapon> weapon;
        public List<Weapon> Weapon
        {
            get { return this.Weapon; }
        }
        public void ChangeHitPoints(int change)
        {
            currentHitPoints += change;
        }
        public void ChangeReputation(int amount)
        {
            reputation += amount;
        }
        public void ChangeMoney(int amount)
        {
            money += amount;
        }
        public void Rest()
        {
            strength = maxStrength;
            endurance = maxEndurance;

            if(currentHitPoints < maxHitPoints)
            {
                currentHitPoints = maxHitPoints;
            }
            Console.WriteLine("your current hitpoints is" + currentHitPoints);
            Console.WriteLine("your strength and endurance have been restored to maximum");
        }
        public void AddPotion()
        {
            potion.Add(new HealthPotion());
        }
        public void RemovePotion(List<HealthPotion> potion)
        {
            potion.RemoveAt(0);
        }

        //cannot add new instance of an abstract class not sure what to do about this method
        // do we need a separate method for each class that inherits from weapon?
        //public void AddWeapon()
        //{
        //    weapon.Add(new Weapon());
        //}

        public bool HasPotion(List<HealthPotion> potion)
        {
            return (potion.Count > 0);
        }
        public bool HasWeapon(List<Weapon> weapon)
        {
            return (weapon.Count > 0);
        }
        public bool IsDead(Hero hero)
        {
            // logic on this method may need work
            while(true)
            {

                if ((hero.currentHitPoints <= 0) && (hero.HasPotion(potion) == true))
                {
                    Console.WriteLine("Do you want to drink your potion with your last dying breath? YES/NO");
                    string userInput = Console.ReadLine().ToUpper();
                    if (userInput == "Y" || userInput == "YES")
                    {
                        Console.WriteLine("drinking potion");
                        potion[0].UseItem(hero);
                        potion.RemoveAt(0);

                    }
                    else return currentHitPoints <= 0;

                }
                
            }
            
        }
        public virtual void BuyBeer(int numberOfBeers)
        {
            money -= Math.Abs(numberOfBeers * 5);
            Console.WriteLine("your current number of coins is" + money);
        }
        // the buying of beer and reduction in money will happen in the bar menu object
        public virtual void DrinkBeer(int numberOfBeers)
        {
            if ((numberOfBeers > 0) && (numberOfBeers < 3))
            {
                
                endurance += 10;
                strength += 10;
                Console.WriteLine("you feel a bit stronger now");
            }
            else if ((numberOfBeers > 3) && (numberOfBeers < 10))
            {
               
                endurance -= 5;
                strength -= 5;
                Console.WriteLine("you're feeling a bit tipsy");
            }
            else if (numberOfBeers > 10)
            {
                
                reputation -= 10;
                endurance -= 15;
                strength -= 15;
                Console.WriteLine("you better not fight in this condition buddy, you're drunk");
            }
            else 
            {
                Console.WriteLine("the barkeep uses an arcane absolute value calculation and charges you accordingly");
                Console.WriteLine("no beer for you");
            }
        }
        // to be added to damage from weapon (or 0 if no weapon)
        public virtual int BaseDamage(int strength)
        {
            Random random = new Random();
            int baseDamage = (strength * random.Next(1, 100)) / 100;
            return baseDamage;
        }
        public void Fight()
        {

        }
        public bool Flee()
        {
            return true;
        }

    }
}
