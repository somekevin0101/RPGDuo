using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.CasinoGames
{
    public class Roulette
    {
        public Roulette(RPG.Classes.Hero player)
        {
            this.player = player;
        }
        public Hero player;
        private int moneyWon = 0;

        public int RouletteSpecificNumber()
        {

            Console.WriteLine("Enter a number between 1 and 36");

            string[] validInputs = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13",
                    "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29",
                    "30", "31", "32", "33", "34", "35", "36"};

            string numInput = Console.ReadLine();

            if (validInputs.Contains(numInput))
            {
                Console.WriteLine("");
                Console.WriteLine("5 coin bet on " + numInput);
                Console.WriteLine("");
                return CalculateRouletteSpecificNumber(numInput);
            }
            else
            {
                Console.WriteLine("That was not a valid bet");
                Console.WriteLine("");

                return moneyWon = 0;
            }

        }

        public int RouletteBlackOrRed()
        {
            Console.WriteLine("Okay then, do you want to bet 5 coins on red or black");

            string[] validInputs = { "red", "black" };
            string inputColor = Console.ReadLine().ToLower();

            if (validInputs.Contains(inputColor))
            {
                Console.WriteLine("");
                Console.WriteLine("5 coin bet on " + inputColor);
                Console.WriteLine("");

                return CalculateRouletteRedOrBlack(inputColor);
            }

            else
            {
                Console.WriteLine("That was not a valid bet");
                return moneyWon = 0;
            }

        }

        public int CalculateRouletteSpecificNumber(string numInput)
        {
            Random random = new Random();
            int result = random.Next(0, 37);

            Console.WriteLine(result + " is a winner!");
            Console.WriteLine("");
            for (int i = 0; i < player.Luck; i++)
            {
                if (result.ToString() == numInput)
                {
                    Console.WriteLine("You won 150 coins!!!!");
                    Console.WriteLine("");
                    return moneyWon = 150;
                }
                result = random.Next(0, 37);
            }
            Console.WriteLine("You lost your 5 coin bet. Better luck next time");
            Console.WriteLine("");
            return moneyWon = -5;
        }

        public int CalculateRouletteRedOrBlack(string inputColor)
        {
            Random random = new Random();
            int result = random.Next(0, 2);


            for (int i = 0; i <= player.Luck/2; i++)
            {
                if ((inputColor == "red" && result == 0) || inputColor == "black" && result == 1)
                {
                    WriteWinningColor(result);
                    Console.WriteLine("You won 5 coins");
                    Console.WriteLine("");

                    return moneyWon = 5;
                }
                result = random.Next(0, 2);
            }
            WriteWinningColor(result);
            Console.WriteLine("Sorry you lost this time");
            Console.WriteLine("");
            return moneyWon = (-5);
        }

        private void WriteWinningColor(int result)
        {
            if (result == 0)
            {
                Console.WriteLine("Red is a winner!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Black is a winner!");
                Console.WriteLine("");
            }
        }

        
    }
}

