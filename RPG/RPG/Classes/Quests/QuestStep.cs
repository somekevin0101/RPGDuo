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
        private List<QuestItem> QuestItemsNeeded;
        private Queue<Enemy> QuestEnemies;

        public QuestStep(Hero hero, string questText, List<QuestItem> itemsNeeded, Queue<Enemy> enemies)
        {
            this.hero = hero;
            this.questText = questText;
            this.QuestItemsNeeded = itemsNeeded;
            this.QuestEnemies = enemies;
        }

        public Boolean StepComplete()// This contains the main logic of the quest
                                     // returns TRUE if step is completed, FALSE otherwise
        {
            foreach (QuestItem questItem in QuestItemsNeeded)
            {
                if (!TurnInQuestItem(questItem))
                {
                    return false;
                }
            }
            if (!AllMonstersDefeated()) // If there are still monsters left, fight them.
            {
                FightMonsters();
                if (!AllMonstersDefeated())// Because the user can still back out early without fighting
                {                        // all the monsters at once, we need to check and see if they're                                 
                    return false;        // actually done or have just backed out for now.
                }
            }
            return true;
        }

        public void GivePlayerQuestItem(QuestItem questItem)
        {
            hero.AddItem(questItem);
        }

        public Boolean TurnInQuestItem(QuestItem questItem)
        {
            foreach (IItem playerItem in hero.InventoryList)
            // Remove the first item with the same name as the quest item required.
            {
                if (playerItem.ItemName == questItem.ItemName)
                {
                    hero.InventoryList.Remove(playerItem);
                    QuestItemsNeeded.Remove(questItem);
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
            while (QuestEnemies.Count != 0)
            {
                CombatCLI combat = new CombatCLI();

                combat.ScriptedBattle(hero, QuestEnemies.Dequeue());

                if (hero.IsDead)
                {
                    return;
                }
                if (QuestEnemies.Count != 0) // Continue if there are still enemies
                {
                    Console.WriteLine("You defeated an enemy!  Would you like to continue?");
                    Console.WriteLine("Enter Y for Yes, or N for no");
                    string continueFighting = Console.ReadLine().ToUpper();

                    if (continueFighting == "N")
                    {
                        break;
                    }
                }
            }
        }
    }
}
