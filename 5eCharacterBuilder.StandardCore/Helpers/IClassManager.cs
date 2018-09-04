using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Helpers
{
    public interface IClassManager
    {
        int IncreaseLevel(int CurrentLevel);
        string AddFeat(string[] CurrentFeats);
    }
}
