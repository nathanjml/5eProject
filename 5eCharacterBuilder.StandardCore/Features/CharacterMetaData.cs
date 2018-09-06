using _5eCharacterBuilder.StandardCore.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Features
{
    [DbTable]
    public class CharacterMetaData : IEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CharacterName { get; set; }
        public string PlayerName { get; set; }
        public string CampaignName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
