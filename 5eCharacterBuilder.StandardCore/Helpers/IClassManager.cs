using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Helpers
{
    public interface IClassManager
    {
        void SetLevel(int level);
        void SetClass(string targetClass);
        void SetRace(string targetRace);
        void SetBackground(string targetBackground);
       
        /* Potentially Needed
        void SetSkillProficiencies();
        void SetSavingThrowProficiencies();
        void SetToolProficiencies();
        Void SetLanguageProficiencies();
        Void SetOtherProficiencies();
        Void SetFeat();
        Void SetCharacterName();  
        Void SetPlayerName();
        Void AddItem();
        Void RemoveItem();
        */
    }
}
