using RPG.Classes.WeaponClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.StoreHelper
{
    public class Inventory
    {
        public List<IItem> GetInventory()
        {
            List<IItem> inventoryList = new List<IItem>();
            inventoryList.Add(new BroadSword());
            inventoryList.Add(new Club());
            inventoryList.Add(new Dagger());
            inventoryList.Add(new BearHands());

            return inventoryList;
        }

        public void PrintInventory(List<IItem> inventoryList)
        {
            Console.WriteLine("Product Number".PadRight(20) + "Product Name".PadRight(23) + "Cost");
            Console.WriteLine("");

            for(int i = 0; i <inventoryList.Count; i++)
            {
                Console.WriteLine((i + 1).ToString().PadRight(20) + inventoryList[i].GetType().Name.PadRight(25)
                    + inventoryList[i].Cost.ToString().PadRight(20));
            }
            Console.WriteLine("");
        }
    }
}
