using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.CasinoGames
{
    public class Roulette
    {
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
                Console.WriteLine("5 coin bet on " + numInput);

                Random random = new Random();
                int result = random.Next(0, 37);

                if (result.ToString() == numInput)
                {
                    Console.WriteLine("You won 150 coins!!!!");
                    return moneyWon = 150;
                }
                else
                {
                    Console.WriteLine("You lost your 5 coin bet. Better luck next time");
                    return moneyWon = -5;
                }
            }
            else
            {
                Console.WriteLine("That was not a valid bet");
                return moneyWon = 0;
            }

        }

        public int RouletteBlackOrRed()
        {
            Console.WriteLine("Okay then, do you want to bet 5 coins on red or black");

            string[] validInputs = { "red", "black" };
            string inputNum = Console.ReadLine().ToLower();

            if (validInputs.Contains(inputNum))
            {
                Console.WriteLine("5 coin bet on " + inputNum);

                Random random = new Random();
                int result = random.Next(0, 2);

                if ((inputNum == "red" && result == 0) || inputNum == "black" && result == 1)
                {
                    Console.WriteLine("You won 5 coins");
                    return moneyWon = 5;
                }
                else
                {
                    Console.WriteLine("Sorry you lost this time");
                    return moneyWon = (-5);
                }

            }

            else
            {
                Console.WriteLine("That was not a valid bet");
                return moneyWon = 0;
            }

        }
    }
}
