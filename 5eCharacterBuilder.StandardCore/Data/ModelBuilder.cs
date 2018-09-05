using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;

namespace _5eCharacterBuilder.StandardCore.Data
{
    public class ModelBuilder : IModelBuilder
    {
        private List<Type> _types = new List<Type>();

        public void Build()
        {

        }

        public void FromAssemblies(params Assembly[] assemblies)
        {
            var allTypes = assemblies.SelectMany(x => x.GetExportedTypes());

            var modelTypesToBuild = allTypes.Where(x =>
                                    x.CustomAttributes.Any(y => 
                                    y.AttributeType == typeof(DbTableAttribute)));

            _types = new List<Type>(modelTypesToBuild);
        }
    }
}
