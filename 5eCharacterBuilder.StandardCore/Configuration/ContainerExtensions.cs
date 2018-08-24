using _5eCharacterBuilder.StandardCore.Data;
using _5eCharacterBuilder.StandardCore.Settings;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;
using _5eCharacterBuilder.StandardCore.Helpers;

namespace _5eCharacterBuilder.StandardCore.Configuration
{
    public static class ContainerExtensions
    {
        public static void ConfigureCore(this Container container, AppSettings appSettings)
        {
            container.RegisterSingleton<IDbContext>(() => new DbContext(appSettings.DbPath));
            container.RegisterSingleton<IMasterContext, MasterContext>();
        }
    }
}
