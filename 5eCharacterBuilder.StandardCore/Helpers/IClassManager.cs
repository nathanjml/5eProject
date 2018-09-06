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
        
    }
}
