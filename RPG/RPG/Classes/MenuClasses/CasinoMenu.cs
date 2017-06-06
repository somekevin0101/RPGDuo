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
    public class CasinoMenu
    {
        public void Display(Hero player)
        {
            Console.WriteLine("The smell of sour beer fills the room, it appears you can choose to play a game or drink beer");
            while (true)
            {
                Console.WriteLine("(1) Buy some beer");
                Console.WriteLine("(2) Play roulette");
                Console.WriteLine("(3) Listen for rumors");
                Console.WriteLine("(Q) Leave the Casino");

                string input = Console.ReadLine().ToUpper();

                if (input == "1" || input == "(1)")
                {
                    Console.WriteLine("The barkeep asks you how many beers you want");
                    Console.WriteLine("");
                    Console.WriteLine("A beer will cost you 2 coin each, enter the number you would like to purchase and drink");

                    string userInput = Console.ReadLine();
                    int beersBought = 0;
                    Int32.TryParse(userInput, out beersBought);
                    // mechanic for increasing or decreasing stats on beer consumption needs to be changed. right
                    // now you can make multiple purchases and it increases/decreases player stats. possible fix is bool parameter
                    // in hero class that can be reset to true after resting. can only purchase beer while true, a 
                    // little awkward though.

                    if(beersBought * 2 == 0)
                    {
                        Console.WriteLine("You might want to try again, you didn't order any beer");
                    }
                    else if(beersBought * 2 <= player.Money)
                    {
                        Console.WriteLine("You purchased " + beersBought + " beers");
                        player.BuyBeer(beersBought);
                        player.DrinkBeer(beersBought);
                    }
                    else
                    {
                        Console.WriteLine("Sorry you don't have enough money for that much beer");
                    }
                    

                }
                else if (input == "2" || input == "(2)")
                {
                    Console.WriteLine("An unscrupulous character asks you to place a bet");
                    Console.WriteLine("");
                    PlayRoulette(player);

                }
                else if (input == "3" || input == "(3)")
                {
                    Console.WriteLine("You walk through the casino and strike up a conversation with a talkative patron");
                    Console.WriteLine("");

                    SQLRumorsDAL rumor = new SQLRumorsDAL();
                    List<string> rumors = new List<string>();
                    rumors = rumor.GetRumor(player);

                    string newRumor = GetRandomRumor(rumors);
                    Console.WriteLine(newRumor);
                    Console.WriteLine("");
                    Console.WriteLine("");

                }

                else if (input == "Q" || input == "(Q)")
                {
                    Console.WriteLine("You leave the Casino");
                    Console.WriteLine("");
                    break;
                }

            }
        }
        public string GetRandomRumor(List<string> rumors)
        {
            string rumor = "";
            int count = rumors.Count();

            if (count > 0)
            {
                Random random = new Random();

                int num = random.Next(0, count - 1);
                rumor = rumors[num];
            }
            else
            {
                rumor = "the bar is empty";
            }
            return rumor;
        }
        public void PlayRoulette(Hero player)
        {
            if(player.Money < 5)
            {
                Console.WriteLine("You need 5 coin to play, sorry buddy");
            }
            else
            {
                Console.WriteLine("(1) place a bet on a number between 1 and 36");
                Console.WriteLine("(2) place a bet on red or black");

                string userInput = Console.ReadLine();

                if(userInput == "1" || userInput == "(1)")
                {
                    Console.WriteLine("Enter a number between 1 and 36");

                    string[] validInputs = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13",
                    "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29",
                    "30", "31", "32", "33", "34", "35", "36"};

                    string numInput = Console.ReadLine();

                    if (validInputs.Contains(numInput))
                    {
                        Console.WriteLine("5 coin bet on " + numInput);

                        Random random = new Random();
                        int result = random.Next(0, 36);
                        
                        if(result.ToString() == numInput)
                        {
                            Console.WriteLine("You won 150 coins!!!!");
                            player.ChangeMoney(150);
                        }
                        else
                        {
                            Console.WriteLine("You lost your 5 coin bet. Better luck next time");
                            player.ChangeMoney(-5);
                        }
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid bet");
                    }

                }
                else
                {
                    Console.WriteLine("Okay then, do you want to bet 5 coins on red or black");

                    string[] validInputs = { "red", "black" };
                    string inputNum = Console.ReadLine().ToLower();

                    if (validInputs.Contains(inputNum))
                    {
                        Console.WriteLine("5 coin bet on " + inputNum);

                        Random random = new Random();
                        int result = random.Next(0, 1);

                        if((inputNum == "red" && result == 0) || inputNum == "black" && result == 1 )
                        {
                            Console.WriteLine("You won 5 coins");
                            player.ChangeMoney(5);
                        }
                        else
                        {
                            Console.WriteLine("Sorry you lost this time");
                            player.ChangeMoney(-5);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("That's not a valid bet");
                    }

                }

            }
        }
    }
}
