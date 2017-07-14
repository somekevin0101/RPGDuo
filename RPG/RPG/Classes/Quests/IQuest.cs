using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.Interfaces
{
    public abstract class Quest
    {
        Hero hero { get;}
        string QuestName { get;}
        int MinReputation {get;}
        int ReputationOnCompletion { get;}
        int GoldOnCompletion { get; }
        List<QuestStep> Steps { get; }
        int currentStep { get;}

        public Quest(Hero h, string questName, int minReputation, int repOnCompletion,    
            int goldOnCompletion, List<QuestStep> steps)
        {
            this.hero = h;
            this.QuestName = questName;
            this.MinReputation = minReputation;
            this.ReputationOnCompletion = repOnCompletion;
            this.GoldOnCompletion = goldOnCompletion;
            this.Steps = steps;
            this.currentStep = 0;
        }

        public void goQuesting()
        {
            if (hero.IsDead)
            {
                return;
            }
        }
    }
}
