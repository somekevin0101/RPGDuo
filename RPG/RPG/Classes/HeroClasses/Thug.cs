using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class Thug : Hero , ICharacter
    {
        // might want to add parameters for adding to traits if giving that option to user
        public Thug(string name)
        {
            this.name = name;
            maxHitPoints = 100;
            currentHitPoints = 100;
            maxEndurance = 10;
            endurance = 10;
            maxStrength = 10;
            strength = 10;
            // potion and weapon list will have nothing in them to start
        }
    }
}
