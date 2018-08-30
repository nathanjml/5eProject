using _5eCharacterBuilder.StandardCore.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Features.GameComponents
{
    public class Feat : IEntity
    {
        public int Id { get; set; }
        public string FeatName { get; set; }
        public string FeatDescription { get; set; }
        public int RulebookPageRef { get; set; }
        public bool IsCustom { get; set; }
    }
}
