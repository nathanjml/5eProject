using _5eCharacterBuilder.StandardCore.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Features.GameComponents
{
    [DbTable]
    public class Feat : IEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FeatName { get; set; }
        public string FeatDescription { get; set; }
        public int RulebookPageRef { get; set; }
        public bool IsCustom { get; set; }
    }
}
