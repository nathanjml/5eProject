using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SimpleInjector;

namespace _5eCharacterBuilder.Configuration
{
    public static class SimpleInjectorConfiguration
    {
        public static void ConfigureXamarin(this Container container)
        {
            container.RegisterInitializer<BaseActivity>((act) => { });
        }
    }
}