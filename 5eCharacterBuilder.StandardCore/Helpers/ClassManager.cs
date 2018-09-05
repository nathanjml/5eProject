using _5eCharacterBuilder.StandardCore.Data;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
