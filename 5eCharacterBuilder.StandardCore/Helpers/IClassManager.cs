using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Helpers
{
    public interface IClassManager
    {
        void IncreaseLevel(int amountBy = 1);
        void DecreaseLevel(int amountBy = 1);
        void ChangeClass(string targetClass);
    }
}
