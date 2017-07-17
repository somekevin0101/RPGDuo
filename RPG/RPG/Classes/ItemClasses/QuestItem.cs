using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.Interfaces
{
    public abstract class QuestItem : IItem
    {
        public string ItemName { get; }
        public int Cost { get; }

        public QuestItem(string itemName)
        {
            this.ItemName = itemName;
            this.Cost = 0; // A quest item should not be sellable for money (I hope...)
        }

        public virtual void UseItem(Hero hero)
        {

        }
        public int DamageDealt()
        {
            return 0;
        }
    }
}
