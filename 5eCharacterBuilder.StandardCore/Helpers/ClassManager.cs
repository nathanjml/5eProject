using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Helpers
{
    public class ClassManager : IClassManager
    {
        private int x;
        private string y;
        //What needs to be included for this to function properly? Surely, this is not the place to add actions as it is only a delegate?

        //public delegate int IncreaseLevel (int CurrentLevel);
        //public delegate string AddFeat(string[] CurrentFeats);

        int IClassManager.IncreaseLevel(int CurrentLevel)
        {
            //Increase the level by 1.
            return x = CurrentLevel + 1;
        }

        string  IClassManager.AddFeat(string[] CurrentFeats)
        {
            //Check Character Feats for duplicates eccept in special cases.
            return y;
        }
    }
}
