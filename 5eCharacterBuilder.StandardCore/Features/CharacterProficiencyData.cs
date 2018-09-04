using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Features
{
    class CharacterProficiencyData
    {
        //How do we handle proficiencies that are not selected by the user 
        //such as class and race proficiency bonuses? Same with Saving Throws.

        //Skill Proficiencies
        public bool AthleticsProf { get; set; }
        public bool AcrobaticsProf { get; set; }
        public bool SleightOfHandProf { get; set; }
        public bool StealthProf { get; set; }
        public bool ArcanaProf { get; set; }
        public bool HistoryProf { get; set; }
        public bool InvestigationProf { get; set; }
        public bool NatureProf { get; set; }
        public bool ReligionProf { get; set; }
        public bool AnimalHandlingProf { get; set; }
        public bool InsightProf { get; set; }
        public bool MedicineProf { get; set; }
        public bool PerceptionProf { get; set; }
        public bool SurvivalProf { get; set; }
        public bool DeceptionProf { get; set; }
        public bool IntimidationProf { get; set; }
        public bool PerformanceProf { get; set; }
        public bool PersuasionProf { get; set; }

        //Saving Throw Proficiencies
        public bool StrengthSavingThrow { get; set; }
        public bool DexteritySavingThrow { get; set; }
        public bool ConstitutionSavingThrow { get; set; }
        public bool IntelligenceSavingThrow { get; set; }
        public bool WisdomSavingThrow { get; set; }
        public bool CharismaSavingThrow { get; set; }

        //Tool Proficiencies

        //Language Proficiencies - possibly done as a string so the user can add custom proficiencies.


    }
}
