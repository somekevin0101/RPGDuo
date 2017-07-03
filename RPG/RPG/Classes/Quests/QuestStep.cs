using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes.EnemyClasses;


namespace RPG.Classes.Interfaces
{
    public abstract class QuestStep
    {
        string questText { get; set; }
        List<IItem> QuestItemsNeeded { get; set; }
        List<Enemy> QuestEnemies { get; set; }

        public abstract void Step(); // This contains the main logic of the quest

        public Boolean PlayerHasQuestItems()
        {
            foreach(IItem questItem in QuestItemsNeeded)
            {

            }

            return false;
        }


    }
}
