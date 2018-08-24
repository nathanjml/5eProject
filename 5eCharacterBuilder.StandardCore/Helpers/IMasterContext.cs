using System;
using System.Collections.Generic;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Helpers
{
    public interface IMasterContext
    {
        int? DataReferenceId { get; set; }
        bool DataAvailable { get; }
    }
}
