using _5eCharacterBuilder.StandardCore.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Features
{
    [DbTable]
    public class CharacterSkillData : IEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int SkillRanksPerLevel { get; set; }
        public int SkillsRanksInvested { get; set; }
        /*Populate below [int] with all skills in game*/
    }
}
