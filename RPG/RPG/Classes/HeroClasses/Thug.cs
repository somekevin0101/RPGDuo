using RPG.Classes.WeaponClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class Thug : Hero , IFight
    {
        // might want to add parameters for adding to traits if giving that option to user
        public Thug(string name)
        {
            this.name = name;
            maxHitPoints = 100;
            currentHitPoints = 100;
            maxEndurance = 10;
            endurance = 10;
            EquippedWeapon = new BareHands();
            maxStrength = 10;
            strength = 10;
            money = 65;
            luck = 10;
            reputation = 5;
            Quests = new Dictionary<string, bool>();
            // potion and weapon list will have nothing in them to start
        }
    }
}
