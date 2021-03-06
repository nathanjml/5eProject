﻿using _5eCharacterBuilder.StandardCore.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Features
{
    [DbTable]
    public class CharacterMainData : IEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int StrScore { get; set; }
        public int DexScrore { get; set; }
        public int ConScore { get; set; }
        public int WisScore { get; set; }
        public int ChaScore { get; set; }
        public int Level { get; set; }
        public string Gender { get; set; }
        public string Homeworld { get; set; }
        public string Alignment { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public string Theme { get; set; }
        public string Background { get; set; }
        //Calculated fields (hp, stamina, etc. not included here).
    }
}
