﻿using System;
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
                Console.WriteLine("(3) Have me hit you really hard");
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
                    List<IItem> weapons = currentInventory.GetInventory();
                    currentInventory.PrintInventory(weapons);

                    Console.WriteLine("What weapon would you like to purchase? (1 - 4)");
                    Console.WriteLine("1. A mighty broadsword");
                    Console.WriteLine("2. A big ol' club");
                    Console.WriteLine("3. A shiny dagger");
                    Console.WriteLine("4. Some bear hands");
                    Console.WriteLine("Q  Buy nothing");
                    string userInput = Console.ReadLine();

                    if(userInput == "1")
                    {
                        BroadSword sword = new BroadSword();
                        if(player.Money >= sword.Cost)
                        {
                            
                            player.AddItem(sword);
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
                            player.AddItem(club);
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
                            player.AddItem(dagger);
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
                    else if (userInput == "4")
                    {
                        BearHands bearhands = new BearHands();
                        if (player.Money > bearhands.Cost)
                        {
                            player.AddItem(bearhands);
                            player.ChangeMoney(-bearhands.Cost);

                            Console.WriteLine("Good choice, those bear claws will be real handy for you.");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("You do not have enough money for that");
                            Console.WriteLine("");

                        }
                    }
                    else if (userInput == "Q" || userInput == "q")
                    {
                        break;
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
                            player.AddItem(potion);
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
                else if (input == "3" || input == "(3)")
                {
                    if(player is Priest)
                    {
                        Console.WriteLine();
                        Console.WriteLine("I can't hit a priest, last time I did that he died on the spot");
                        Console.WriteLine("Geez why did you remind me of that, get out of my shop!!!!");
                        Console.WriteLine();
                        break;
                    }
                    Console.WriteLine(); 
                    Console.WriteLine("Oh man I love it when people ask me to do that!!");

                    player.ChangeHitPoints(-91);

                    player.IsDead = player.GetDeathStatus();

                    if (player.IsDead)
                    {
                        Console.WriteLine();
                        Console.WriteLine("I hit you way too hard. I hate it when this happens!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(player.Name + " , you sure can take a punch");
                        Console.WriteLine();
                    }
                    
                }
                else if (input == "Q" || input == "(Q)")
                {
                    Console.Clear();
                    Console.WriteLine("Have a nice day");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
