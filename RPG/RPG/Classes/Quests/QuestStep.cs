using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes.EnemyClasses;
using RPG.Classes.Combat;


namespace RPG.Classes.Interfaces
{
    public abstract class QuestStep
    {

        private Hero hero;
        string questText { get; set; }
        List<IItem> QuestItemsNeeded { get; set; }
        Queue<Enemy> QuestEnemies { get; set; }

        public QuestStep(Hero hero, string questText, List<IItem> itemsNeeded, Queue<Enemy> enemies)
        {
            this.hero = hero;
            this.questText = questText;
            this.QuestItemsNeeded = itemsNeeded;
            this.QuestEnemies = enemies;
        }

        public Boolean StepComplete()// This contains the main logic of the quest
                                     // returns TRUE if step is completed, FALSE otherwise
        {
            foreach (IItem questItem in QuestItemsNeeded)
            {
                if (!PlayerHasItem(questItem))
                {
                    return false;
                }
                else if (!GiveAwayQuestItem(questItem))
                {
                    return false;
                }
            }
            //Logic for beating up enemies still needs to be implemented
            throw new NotImplementedException();
        }

        public Boolean PlayerHasItem(IItem itemDesired)
        {
            foreach(IItem playerItem in hero.InventoryList)
            {
                if( playerItem.ItemName == itemDesired.ItemName)
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean GiveAwayQuestItem(IItem questItem)
        {
            foreach(IItem playerItem in hero.InventoryList)
            {
                if (playerItem.ItemName == questItem.ItemName)
                {
                    hero.InventoryList.Remove(playerItem);
                    return true;
                }
            }
            return false;
        }

        public Boolean AllMonstersDefeated()
        {
            return QuestEnemies.Count == 0;
        }
        
        public void FightMonsters()
        {
            for (int i = 0; i < QuestEnemies.Count; i += 0)
            {
                
            }
        }
    }
}
