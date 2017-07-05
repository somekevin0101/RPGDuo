using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.MenuClasses
{
    public class InventoryMenu
    {
        public void Display(Hero player)
        {
            Console.WriteLine();
            Console.WriteLine("Choose a weapon to use in battle");

            List<IItem> weaponList = new List<IItem>();

            foreach(IItem w in player.InventoryList)
            {
                if(w is Weapon)
                {
                    weaponList.Add(w);
                }
            }

            if(weaponList.Count < 0)
            {
                Console.WriteLine("There are no weapons in inventory");
                Console.WriteLine();
            }
            else
            {
                ChooseWeapon(player, weaponList);
            }
        }

        public void ChooseWeapon(Hero player, List<IItem> weaponList)
        {
            for (int i = 0; i < weaponList.Count; i++)
            {
                Console.WriteLine((i + 1) + "        " + weaponList[i].GetType().Name);
            }
            Console.WriteLine();
            Console.WriteLine("Please enter a number to choose your weapon");
            Console.WriteLine();

            string userInput = Console.ReadLine();
            int userNumber = 0;
            Int32.TryParse(userInput, out userNumber);
            if(userNumber <= 0 || userNumber > weaponList.Count)
            {
                Console.WriteLine("That was not a valid number");
            }
            else
            {
                player.EquippedWeapon = weaponList[userNumber - 1];
                Console.WriteLine("You have equipped a " + weaponList[userNumber - 1].GetType().Name);
            }

        }
    }
}
