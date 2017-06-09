using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public interface IFight
    {
        int currentHealth { get;}
        bool Fight();
        bool Flee();

    }
}
