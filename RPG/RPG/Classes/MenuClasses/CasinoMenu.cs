using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RPG.Classes.EnemyClasses;
using RPG.Classes.HeroClasses;
using RPG.Classes.MenuClasses;
using RPG.Classes;
using RPG.Classes.CasinoGames;
using RPG.Classes.Interfaces;

namespace RPG.Classes.MenuClasses
{
    public class CasinoMenu
    {
        readonly string RumorConnect = ConfigurationManager.ConnectionStrings["RumorConnection"].ConnectionString;

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

                    if (beersBought * 2 == 0)
                    {
                        Console.WriteLine("You might want to try again, you didn't order any beer");
                    }

                    else if (beersBought * 2 <= player.Money)
                    {
                        Console.WriteLine("");
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
                    if (player.IsTooLucky)
                    {
                        Console.WriteLine();
                        Console.WriteLine("We don't like cheaters around here, get out!!!!");
                        Console.WriteLine();
                        break;
                    }
                    Console.WriteLine("An unscrupulous character asks you to place a bet");
                    Console.WriteLine("");
                    PlayRoulette(player);

                }

                else if (input == "3" || input == "(3)")
                {
                    Console.WriteLine("You walk through the casino and strike up a conversation with a talkative patron");
                    Console.WriteLine("");

                    IRumorDAL rumor = new SQLRumorsDAL(RumorConnect);
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
            Roulette roulette = new Roulette(player);

            if (player.Money < 5)
            {
                Console.WriteLine("You need 5 coin to play, sorry buddy");
            }
            else
            {
                Console.WriteLine("(1) place a bet on a number between 1 and 36");
                Console.WriteLine("(2) place a bet on red or black");

                string userInput = Console.ReadLine();

                if (userInput == "1" || userInput == "(1)")
                {
                    int moneyWon = 0;
                    moneyWon = roulette.RouletteSpecificNumber();

                    player.GamblingAttemptsCounter();

                    if(moneyWon > 0)
                    {
                        player.GamblingSuccessesCounter();
                    }

                    player.ChangeMoney(moneyWon);

                }
                else if (userInput == "2" || userInput == "(2)")
                {
                    int moneyWon = 0;
                    moneyWon = roulette.RouletteBlackOrRed();

                    player.GamblingAttemptsCounter();
                    
                    if(moneyWon > 0)
                    {
                        player.GamblingSuccessesCounter();
                    }

                    player.ChangeMoney(moneyWon);
                }
                else
                {
                    Console.WriteLine("That's not a valid bet");
                }

            }

        }
    }
}

