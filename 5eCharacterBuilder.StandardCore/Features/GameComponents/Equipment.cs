using _5eCharacterBuilder.StandardCore.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Features.GameComponents
{
    [DbTable]
    public class Equipment : IEntity
    {
        [PrimaryKey, Unique]
        public int Id { get; set; }
        public int Value { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCustom { get; set; }
    }
}
