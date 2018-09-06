using _5eCharacterBuilder.StandardCore.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Features
{
    [DbTable]
    public class CharacterEquipmentData : IEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string ItemType { get; set; }
        public string ItemBaseCost { get; set; }
        public bool ItemIsUnique { get; set; }
        public bool ItemHasEffects { get; set; }
        public string ItemName { get; set; }
        public int FKItemTableRef { get; set; }
    }
}
