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
                if (!GiveAwayQuestItem(questItem))
                {
                    return false;
                }
            }
            //Logic for beating up enemies still needs to be implemented
            if (!AllMonstersDefeated())
            {
                FightMonsters();
            }

            return true;
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
            while(QuestEnemies.Count != 0)
            {
                CombatCLI combat = new CombatCLI();

                Console.WriteLine("You defeated an enemy!  Would you like to continue?");
                Console.WriteLine("Enter Y for Yes, or N for no");
                string continueFighting = Console.ReadLine().ToUpper();

                combat.ScriptedBattle(hero, QuestEnemies.Dequeue());

                if (hero.IsDead)
                {
                    return;
                }





            }
        }
    }
}
