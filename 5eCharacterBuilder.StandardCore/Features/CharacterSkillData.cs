using _5eCharacterBuilder.StandardCore.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Features
{
    public class CharacterSkillData : IEntity
    {
        public int Id { get; set; }
        public int SkillRanksPerLevel { get; set; }
        public int SkillsRanksInvested { get; set; }
        /*Populate below [int] with all skills in game*/
    }
}
