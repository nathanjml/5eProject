using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eCharacterBuilder.StandardCore.Data
{
    public class ModelBuilder : IModelBuilder
    {
        private List<Type> _types = new List<Type>();
        private readonly IDbContext _context;

        public ModelBuilder(IDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Build()
        {
            var createTable = _context.GetType()
                                      .GetMethods()
                                      .Single(x => x.Name == "CreateOrUpdateTable" &&
                                              x.GetParameters().Length == 0 &&
                                              x.GetGenericArguments().Length == 1);
            var nullParams = new object[] { };
            try
            {
                var tasks = _types
                    .Select(x => createTable
                            .MakeGenericMethod(x)
                            .Invoke(_context, nullParams))
                    .Cast<Task>()
                    .ToArray();

                Task.WaitAll(tasks);
            }
            catch (Exception e)
            {
                throw e;
            }
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
