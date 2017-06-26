using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public interface IFight
    {
        // commented out due to compile issues
        int CurrentHitPoints { get;}
        bool GetDeathStatus();
        int DamageDone();
        void ChangeHitPoints(int changedAmount);
        //bool Fight();
        //  bool Flee();

    }
}
