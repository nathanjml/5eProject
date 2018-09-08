using _5eCharacterBuilder.StandardCore.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Features
{
    [DbTable]
    class CharacterBackgroundData
    {
        [PrimaryKey, Unique]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Skills { get; set; }
        public string Language { get; set; }
        public string Tool { get; set; }
    }
}
