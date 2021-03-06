﻿using System;
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
    public class InnMenu
    {
        public void Display(Hero player)
        {
            Console.WriteLine("You see an young woman behind a desk, she asks if you want a room for the night");
            if (player is Thug || player.Reputation < 10)
            {
                Console.WriteLine("and glares at you, brings a large dagger out and begins to whistle");
            }

                while (true)
            {
                Console.WriteLine("(1) Purchase a room");
                Console.WriteLine("(2) Check your stats");
                Console.WriteLine("(3) Work for money");
                Console.WriteLine("(Q) Leave the inn");

                string input = Console.ReadLine().ToUpper();

                if (input == "1" || input == "(1)")
                {
                    if(player.Money >= 5)
                    {
                        if (player.Reputation >= 50)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Only the finest for a person of your repute " + player.Name);
                            Console.WriteLine("");
                        }
                        else if (player.Reputation >= 10)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("We have a modest room that was just tidied up");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You can sleep in the stables");
                        }
                        player.Rest();
                        player.ChangeMoney(-5);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I'm sorry but you don't have enough money");
                        Console.WriteLine("");
                    }

                }
                else if (input == "2" || input == "(2)")
                {
                    // this should be pulled out into a method
                    Console.WriteLine("Here are your current stats:");
                    Console.WriteLine("Equipped Weapon: " + player.EquippedWeapon.GetType().Name);
                    Console.WriteLine("HP: " + player.CurrentHitPoints.ToString());
                    Console.WriteLine("Strength: " + player.Strength.ToString());
                    Console.WriteLine("Endurance: " + player.Endurance.ToString());
                    Console.WriteLine("Luck : " + player.Luck.ToString());
                    Console.WriteLine("Reputation :" + player.Reputation.ToString());
                    Console.WriteLine("Money : " + player.Money.ToString());

                    foreach(IItem item in player.InventoryList)
                    {
                        Console.WriteLine(item.GetType().Name);
                    }
                }

                else if (input == "3" || input == "(3)")
                {
                    Console.WriteLine("You want to work for some coins?  Well, get scrubbing then.");
                    Console.WriteLine("These pots won't clean themselves!");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("After a long day of cleaning pots, the innkeeper hands you 3 coins.");
                    player.ChangeMoney(3);


                }
                else if (input == "Q" || input == "(Q)")
                {
                    Console.Clear();
                    Console.WriteLine("Have a nice day");
                    Console.WriteLine("");
                    break;
                }
            }
        }
    }
}
