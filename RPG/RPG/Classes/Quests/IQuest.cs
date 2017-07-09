using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes.Interfaces
{
    public interface IQuest
    {
        Hero hero { get; set; }
        string QuestName { get; set; }
        int MinReputation {get;set;}
        int ReputationOnCompletion { get; set; }
        int GoldOnCompletion { get; set; }
        List<QuestStep> Steps { get; set; }
        int currentStep { get; set; }
    }
}
