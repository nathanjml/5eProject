using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Data
{
    public interface IModelBuilder
    {
        void Build();
        void FromAssemblies(params Assembly[] assemblies);
    }
}
