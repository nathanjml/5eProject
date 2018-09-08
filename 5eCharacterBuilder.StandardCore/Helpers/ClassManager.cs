using _5eCharacterBuilder.StandardCore.Data;
using System;
using System.Collections.Generic;
using System.Text;


using System.Linq;
using _5eCharacterBuilder.StandardCore.Features;

namespace _5eCharacterBuilder.StandardCore.Helpers
{
    public class ClassManager : IClassManager
    {
        private readonly IDbContext _dbContext;
        private readonly IMasterContext _masterContext;

        public ClassManager(IDbContext dbContext, IMasterContext masterContext)
        {
            _dbContext = dbContext;
            _masterContext = masterContext;
        }

        public void SetClass(string targetClass)
        {
            throw new NotImplementedException();
        }

        public void SetLevel(int level)
        {
            throw new NotImplementedException();
        }

        public void SetRace(string targetRace)
        {
            throw new NotImplementedException();
        }

        public void SetBackground(string targetBackground)
        {
            /*Notes: We need to access a specific character, pull the targetBackground from the database, and apply the background to this character.
              The below might not make sense, but my logic is as follows. Using Linq, we search through all the names in the CharacterBackground table.
              Then, we select the Background we are looking for, and apply the name to the CharacterMainData Table where we hold a Foreign relationship between
              both tables. Looking forward to your instruction on how this needs to be implimented. 
             
            IEnumerable<string> background =
                from Name in CharacterBackgroundData
                where Name = targetBackground
                select Name;

            _dbContext.SaveItemAsync(background);
            */
        }
    }
}
