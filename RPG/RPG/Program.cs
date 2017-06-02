using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes.EnemyClasses;
using RPG.Classes.HeroClasses;
using RPG.Classes.MenuClasses;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            TownMenu town = new TownMenu();
            town.Display();
        }
    }
}
