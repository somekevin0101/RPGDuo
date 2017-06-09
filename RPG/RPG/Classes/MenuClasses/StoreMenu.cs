using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes.EnemyClasses;
using RPG.Classes.HeroClasses;
using RPG.Classes.MenuClasses;
using RPG.Classes;
using RPG.Classes.StoreHelper;
using RPG.Classes.WeaponClasses;

namespace RPG.Classes.MenuClasses
{
    public class StoreMenu
    {
        public void Display(Hero player)
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
                    if(player is Archer)
                    {
                        Console.WriteLine("You have the look of a coward about you, I'm sorry but we don't carry bows and arrows");
                    }
                    Console.WriteLine("We have many fine weapons befitting a hero");
                    Console.WriteLine("");

                    Inventory currentInventory = new Inventory();
                    List<Weapon> weapons = currentInventory.GetInventory();
                    currentInventory.PrintInventory(weapons);

                    Console.WriteLine("What weapon would you like to purchase? (1 - 3)");
                    string userInput = Console.ReadLine();

                    if(userInput == "1")
                    {
                        BroadSword sword = new BroadSword();
                        if(player.Money >= sword.Cost)
                        {
                            
                            player.AddWeapon(sword);
                            player.ChangeMoney(-sword.Cost);

                            Console.WriteLine("Enjoy your new Broadsword!");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("You do not have enough money for that");
                            Console.WriteLine("");
                        }

                    }
                    else if(userInput == "2")
                    {
                        Club club = new Club();
                        if(player.Money >= club.Cost)
                        {
                            player.AddWeapon(club);
                            player.ChangeMoney(-club.Cost);

                            Console.WriteLine("That's a mighty club for a mighty warrior! Enjoy!");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("You do not have enough money for that");
                            Console.WriteLine("");
                        }
                    }

                    else if(userInput == "3")
                    {
                        Dagger dagger = new Dagger();
                        if(player.Money > dagger.Cost)
                        {
                            player.AddWeapon(dagger);
                            player.ChangeMoney(-dagger.Cost);

                            Console.WriteLine("A beautiful dagger, Enjoy!!");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("You do not have enough money for that");
                            Console.WriteLine("");

                        }
                    }
                    else
                    {
                        Console.WriteLine("I didn't catch what you meant, please try again");
                        Console.WriteLine("");
                    }

                }
                else if (input == "2" || input == "(2)")
                {
                    HealthPotion potion = new HealthPotion();
                    Console.WriteLine("Hmm health potions taste awful but they do heal you");
                    Console.WriteLine("");
                    if(player.Money > potion.Cost)
                    {
                        Console.WriteLine("A health potion will cost you " + potion.Cost + " coin, would you like one?(Y/N)");
                        string userInput = Console.ReadLine().ToUpper();

                        if(userInput == "Y" || userInput == "YES")
                        {
                            player.AddPotion(potion);
                            player.ChangeMoney(-potion.Cost);

                            Console.WriteLine();
                            Console.WriteLine("Enjoy your purchase " + player.Name + ("!!!"));
                            Console.WriteLine();
                        }

                        else if(userInput == "N" || userInput == "NO")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Suit yourself buddy");
                            Console.WriteLine();
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("I didn't understand you");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Unfortunately you can't afford the " + potion.Cost + " cost");
                        Console.WriteLine();
                    }
                }
                else if (input == "Q" || input == "(Q)")
                {
                    Console.WriteLine();
                    Console.WriteLine("Have a nice day");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
