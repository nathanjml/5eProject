using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Helpers
{
    public class MasterContext : IMasterContext
    {
        public int? DataReferenceId { get; set; }
        public bool DataAvailable => DataReferenceId.HasValue;
    }
}
