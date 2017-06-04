using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.Interfaces
{
    public interface IRumorDAL
    {
         List<string> GetRumor(Hero player);
    }
}
